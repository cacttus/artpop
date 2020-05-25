using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArtPop
{
    public class ImageSizeFilter
    {
        public int MinWidth { get; set; }
        public int MaxWidth { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
    }

    public class FileCache
    {
        public int Searched { get; private set; }

        public List<string> ExcludedFiles { get; set; } = new List<string>();
        public List<string> FavoritedFiles { get; set; } = new List<string>();

        public List<string> Files
        {
            get { lock (_objFileCacheLockObject) { return _lstCachedFileList; } }
            set { lock (_objFileCacheLockObject) { _lstCachedFileList = value; } }
        }
        public bool Searching
        {
            get
            {
                return SearchTask != null && SearchTask.IsCanceled == false && SearchTask.IsCompleted == false;
            }
        }
        private List<string> _lstCachedFileList = new List<string>();//DO NOT USE - use FileCache instead
        private Object _objFileCacheLockObject = new Object();
        private Action _objCompletionAction;
        private CancellationToken SearchTaskCancellationToken;
        private CancellationTokenSource SearchTaskCancellationTokenSource;
        private Task SearchTask = null;

        public FileCache()
        {
        }
        public void RemoveFile(int index)
        {
            Files.RemoveAt(index);
        }
        public void CancelSearch()
        {
            SearchTaskCancellationTokenSource.Cancel();
        }
        public void Search(string dir, ImageSizeFilter filter, Action<double> objProgressAction = null, Action objCompletionAction = null)
        {
            _objCompletionAction = objCompletionAction;

            if (!System.IO.Directory.Exists(dir))
            {
                Globals.LogError("Path " + dir + " does not exist.");
                //Invoke completion action on main thread, regardless of failure or success
                Globals.MainForm.BeginInvoke((Action)(() =>
                {
                    objCompletionAction();
                }));
            }
            else
            {
                List<string> lstExtensions = Globals.MainForm.SettingsForm.GetFileTypes();

                SearchTaskCancellationTokenSource = new CancellationTokenSource();
                SearchTaskCancellationToken = SearchTaskCancellationTokenSource.Token;

                SearchTask = new Task(((Action)(() =>
                {
                    try
                    {

                        Globals.MainForm.SetSearchStatus("Gathering Files...");
                        //*Faster than gather files recursively
                        //*Also faster than Directory.GetFiles avoids memory issues
                        //https://stackoverflow.com/questions/163162/can-you-call-directory-getfiles-with-multiple-filters
                        IEnumerable<string> files = Directory.EnumerateFiles(
                            dir, "*.*",
                            SearchOption.AllDirectories
                            ).ToArray();

                        Searched = 0;

                        Globals.MainForm.SetSearchStatus("Filtering Extensions...");

                        string eTest = System.IO.Path.GetExtension(files.ToList()[0]);

                        //Filter Extensions
                        List<string> filtered = files.Where(x =>
                            System.IO.Path.GetExtension(x).Length > 0 ?
                            lstExtensions.Contains(
                                System.IO.Path.GetExtension(x).ToLower()
                            ) : false
                        ).ToList();

                        //Filter width /height
                        Globals.MainForm.SetSearchStatus("Filtering Width/Height...");
                        FilterWidthHeight(filtered, filter, objProgressAction);

                        Globals.MainForm.SetSearchStatus("Filtering: Excluding " + ExcludedFiles.Count.ToString() + " Files...");
                        foreach (string s in ExcludedFiles)
                        {
                            filtered.RemoveAll(x => String.IsNullOrEmpty(x) || x.Equals(s));
                        }

                        lock (_objFileCacheLockObject)
                        {
                            Files = filtered;
                        }
                        Globals.MainForm.SetSearchStatus("Done.");
                    }
                    catch (Exception ex)
                    {
                        Globals.LogError(ex.ToString());
                        Globals.MainForm.SetSearchStatus("Error during search.");
                    }

                    //Invoke completion action on main thread, regardless of failure or success
                    Globals.MainForm.BeginInvoke((Action)(() =>
                    {
                        objCompletionAction();
                    }));
                })), SearchTaskCancellationToken);

                SearchTask.Start();
            }
        }
        public int TotalWHFiltered { get; private set; } = 0;

        private void FilterWidthHeight(List<string> lstFiles, ImageSizeFilter minimax, Action<double> progress)
        {
            //Launch 1 thread per processor to filter images
            TotalWHFiltered = 0;

            //Filter the image width /height
            List<string> filtered2 = new List<string>();
            if (minimax != null)
            {
                int n = System.Environment.ProcessorCount;
                int perProc = lstFiles.Count / n;

                List<Task> tasks = new List<Task>();
                List<CancellationTokenSource> sources = new List<CancellationTokenSource>();
                List<int> starts = new List<int>();

                int len = lstFiles.Count / n;

                for (int iproc = 0; iproc < n; ++iproc)
                {
                    starts.Add(lstFiles.Count / n * iproc);
                }

                TotalWHFiltered = 0;

                //Send off child threads.
                for (int iproc = 0; iproc < n; ++iproc)
                {
                    //capture data for thread
                    CancellationTokenSource s = new CancellationTokenSource();
                    sources.Add(s);

                    CancellationTokenSource myToken = sources[iproc];

                    int temp = iproc;

                    Task tak = new Task(((Action)(() =>
                    {
                        int ifile;
                        for (ifile = starts[temp]; ifile < (starts[temp] + len); ++ifile)
                        {
                            TotalWHFiltered++;

                            if (TotalWHFiltered % 50 == 0)
                            {
                                Globals.MainForm.SetSearchStatus("Filtering W/H..." + TotalWHFiltered + "/" + lstFiles.Count);
                                progress?.Invoke((double)TotalWHFiltered / (double)lstFiles.Count);
                            }
                            if (myToken.IsCancellationRequested)
                            {
                                break;
                            }

                            if (ifile >= lstFiles.Count)
                            {
                                break;
                            }

                            string strPath = lstFiles[ifile];

                            try
                            {
                                if (File.Exists(strPath))
                                {
                                    using (FileStream stream = new FileStream(strPath, FileMode.Open, FileAccess.Read))
                                    {
                                        //False 2nd 3rd parameter to avoid loading file into memer\
                                        //http://stackoverflow.com/questions/552467/how-do-i-reliably-get-an-image-dimensions-in-net-without-loading-the-image
                                        Image img = Image.FromStream(stream, false, false);
                                        if (img.Width > minimax.MinWidth && img.Width < minimax.MaxWidth &&
                                            img.Height > minimax.MinHeight && img.Height < minimax.MaxHeight)
                                        {
                                            filtered2.Add(strPath);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //Swallow
                            }
                        }

                    })), myToken.Token);

                    tak.Start();

                    tasks.Add(tak);
                }

                //Block this thread until all baby threads are done reading files
                while (true)
                {
                    //See if we are killed by the user.
                    if (this.SearchTaskCancellationToken.IsCancellationRequested)
                    {
                        //Cancel all tasks
                        foreach (CancellationTokenSource s in sources)
                        {
                            s.Cancel();
                        }
                        Thread.Sleep(500);
                        break;
                    }

                    //Check to see if all takss have completed.
                    int tasks_running = tasks.Count;
                    foreach (Task t in tasks)
                    {
                        if (t.IsCanceled == true || t.IsCompleted == true)
                        {
                            tasks_running--;
                        }
                    }
                    if (tasks_running == 0)
                    {
                        break;
                    }

                    Thread.Sleep(50);
                }
            }
            lstFiles.Clear();
            lstFiles.AddRange(filtered2);
        }


    }
}
