using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ArtPop
{
    public partial class SessionEditorForm : MonoEditForm
    {
        bool _bChanged = false;

        public SessionEditorForm()
        {
            InitializeComponent();
        }
        private void HideHorizontalScrollBar()
        {

        }
        private void UpdateSessionStats()
        {
            TimeSpan duration = new TimeSpan(0);
            Session s = GetSelectedSession();
            if (s != null)
            {
                _pnlSessionStats.Visible = true;

                foreach (int exerciseId in s.Exercises)
                {
                    Exercise exercise = Globals.MainForm.SettingsForm.Exercises.Where(x => x.Id == exerciseId).FirstOrDefault();
                    if (exercise != null)
                    {
                        duration += exercise.Duration;
                    }
                }
                string fmt = "";
                if (duration.Hours > 0)
                {
                    fmt = duration.Hours + " hours, " + duration.Minutes + " minutes, " + duration.Seconds + " seconds";
                }
                else if (duration.Minutes > 0)
                {
                    fmt = duration.Minutes + " minutes, " + duration.Seconds + " seconds";
                }
                else if (duration.Seconds > 0)
                {
                    fmt = duration.Seconds + " seconds";
                }
                _lblSessionDuration.Text = fmt;
            }
            else
            {
                _pnlSessionStats.Visible = false;
            }
        }
        private void SessionEditorForm_Load(object sender, EventArgs e)
        {
            Globals.RegisterExtensions(this);

            _lsvSessionExercises.Scrollable = true;
            _lsvSessionExercises.View = System.Windows.Forms.View.Details;
            _lsvSessionExercises.Columns.Add(new ColumnHeader() { Text = "", Name = "col1" });

            _lsvConfiguredExercises.Scrollable = true;
            _lsvConfiguredExercises.View = System.Windows.Forms.View.Details;
            _lsvConfiguredExercises.Columns.Add(new ColumnHeader() { Text = "", Name = "col1" });

            _lsvSessionExercises.Columns[0].Width = Width - 4 - SystemInformation.VerticalScrollBarWidth;
            _lsvConfiguredExercises.Columns[0].Width = Width - 4 - SystemInformation.VerticalScrollBarWidth;

            _txtName.LostFocus += _txtName_LostFocus;
            _cboSessionList.FormattingEnabled = true;
            RefreshData();

            Globals.SetTooltip(_btnNewSession, new Phrase("New Routine", "New Routine"));
            Globals.SetTooltip(_btnDeleteSession, new Phrase("Delete Routine", "Delete Routine"));
            Globals.SetTooltip(_btnAddConfiguredExercise, new Phrase("Add Configured Exercise"));
            Globals.SetTooltip(_btnRemoveConfiguredExercise, new Phrase("Remove Configured Exercise"));
            Globals.SetTooltip(_btnEditConfiguredExercise, new Phrase("Edit Configured Exercise"));
            Globals.SetTooltip(_btnMoveLeft, new Phrase("Add the selected exercise to this routine."));
            Globals.SetTooltip(_btnMoveExerciseUp, new Phrase("Move Exercise Up"));
            Globals.SetTooltip(_btnMoveExerciseDown, new Phrase("Move Exercise Down"));
            Globals.SetTooltip(_btnDeleteSessionExercise, new Phrase("Remove Exercise"));
            Globals.SetTooltip(_lsvSessionExercises, new Phrase("Exercises for this Routine"));
            Globals.SetTooltip(_lsvConfiguredExercises, new Phrase("Configured Exercises"));
            Globals.SetTooltip(_cboSessionList, new Phrase("Select a Session to edit."));

            ToggleEditorVisible();

            MarkChanged(false);
        }
        private void ToggleEditorVisible() {
            gbRoutineEditor.Visible = !(GetSelectedSession() == null);
        }

        private void _txtName_LostFocus(object sender, EventArgs e)
        {
            AcceptSessionName();
        }
        private void AcceptSessionName()
        {
            int i = _cboSessionList.SelectedIndex;
            RefreshSessionsComboBox();
            _cboSessionList.SelectedIndex = i;
        }
        private void RefreshData()
        {
            RefreshSessionsComboBox();
            RefreshConfiguredExercises();

            PopulateSession(null);
        }
        private void RefreshSessionsComboBox()
        {
            _cboSessionList.Items.Clear();
            foreach (Session s in Globals.MainForm.SettingsForm.Sessions)
            {
                _cboSessionList.Items.Add(s.Name);
            }

            //This will reset everything\
            //https://stackoverflow.com/questions/10427172/how-to-deleselect-blank-a-databound-combobox-selectedindex-1-does-not-work
            _cboSessionList.ResetText();
            _cboSessionList.SelectedValue = null;
            _cboSessionList.SelectedIndex = -1;
        }
        private void RefreshConfiguredExercises()
        {
            _lsvConfiguredExercises.Items.Clear();
            foreach (Exercise ee in Globals.MainForm.SettingsForm.Exercises)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ee.Name;
                lvi.Tag = ee;
                _lsvConfiguredExercises.Items.Add(lvi);
            }
        }
        private void _btnNewSession_Click(object sender, EventArgs e)
        {
            Session s = new Session();
            s.Name = "MySession";

            int suffix = 1;
            while (Globals.MainForm.SettingsForm.Sessions.Where(x => x.Name.Equals(s.Name)).FirstOrDefault() != null)
            {
                suffix++;
                s.Name = "MySession-" + suffix.ToString();
            }

            Globals.MainForm.SettingsForm.Sessions.Add(s);

            RefreshSessionsComboBox();

            SelectSession(s);
        }
        private void SelectSession(Session s)
        {
            int ind = 0;
            for (; ind < Globals.MainForm.SettingsForm.Sessions.Count; ++ind)
            {
                if (Globals.MainForm.SettingsForm.Sessions[ind] == s)
                {
                    break;
                }
            }
            if (ind >= 0 && ind < _cboSessionList.Items.Count)
            {
                _cboSessionList.SelectedIndex = ind;
            }
        }
        public Session GetSelectedSession()
        {
            if (_cboSessionList.SelectedIndex < 0)
            {
                return null;
            }
            return Globals.MainForm.SettingsForm.Sessions[_cboSessionList.SelectedIndex];
        }
        private void _cboSessionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSelectedSession();
        }
        private void PopulateSelectedSession()
        {
            if (_cboSessionList.SelectedIndex >= 0)
            {
                Session s = Globals.MainForm.SettingsForm.Sessions[_cboSessionList.SelectedIndex];
                PopulateSession(s);
            }
            else
            {
                //We de-selected the combobox so blank out the form
                PopulateSession(null);
            }
            ToggleEditorVisible();
        }
        private void PopulateSession(Session s)
        {
            RefreshConfiguredExercises();
            if (s == null)
            {
                _txtName.Text = "";
                _lsvSessionExercises.Items.Clear();
                EnableSessionArea(false);
            }
            else
            {
                _txtName.Text = s.Name;
                _lsvSessionExercises.Items.Clear();

                foreach (int id in s.Exercises)
                {
                    MoveExerciseToSession(id);
                }

                EnableSessionArea(true);
            }

            UpdateSessionStats();
        }
        private void EnableSessionArea(bool enable)
        {
            _btnMoveLeft.Enabled =
                _btnDeleteSessionExercise.Enabled =
                _btnMoveExerciseDown.Enabled =
                _btnMoveExerciseUp.Enabled =
                _lsvSessionExercises.Enabled =
                _btnMoveLeft.Enabled =
                _lsvSessionExercises.Enabled =
                _txtName.Enabled =
                _pnlSessionStats.Visible=
                enable;
        }
        private void MoveExerciseToSession(int id)
        {
            //Move a Configured Exercise to the session list and remove it from the configured list.
            MoveExercise(id, _lsvConfiguredExercises, _lsvSessionExercises, false);
        }
        private void MoveExerciseFromSession(int id)
        {
            //Remove a Exercise from the session list and add it to the configured list.
            MoveExercise(id, _lsvSessionExercises, _lsvConfiguredExercises, true);
        }
        private void MoveExercise(int id,
            MetroFramework.Controls.MetroListView lsv_from,
            MetroFramework.Controls.MetroListView lsv_to,
            bool deleteMovedFrom)
        {
            Exercise ee = Globals.MainForm.SettingsForm.Exercises.Where(x => x.Id == id).FirstOrDefault();
            if (ee != null)
            {
                //Remove it from configured Exercises
                ListViewItem found = null;
                foreach (ListViewItem lv in lsv_from.Items)
                {
                    if (lv.Tag == ee)
                    {
                        found = lv;
                        break;
                    }
                }
                if (found != null)
                {
                    if (deleteMovedFrom)
                    {
                        lsv_from.Items.Remove(found);
                    }

                    //It's ok to add multiples of the same.

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ee.Name;
                    lvi.Tag = ee;
                    lsv_to.Items.Add(lvi);

                }
                else
                {
                    Globals.LogError("Could not find Listview exercise");
                }
            }
            else
            {
                Globals.LogError("Could not find exercise with given ID of " + id);
            }
        }
        private void _btnRemoveExercise_Click(object sender, EventArgs e)
        {

        }

        private void _btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (_cboSessionList.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Delete session? This Cannot be undone.",
                    "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Globals.MainForm.SettingsForm.Sessions.RemoveAt(_cboSessionList.SelectedIndex);
                    RefreshData();
                    //https://stackoverflow.com/questions/23910733/how-to-have-a-control-redraw-the-windows-form
                    Invalidate();
                    Refresh();
                    PopulateSelectedSession();

                }


            }
        }

        private void _btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (_lsvConfiguredExercises.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in _lsvConfiguredExercises.SelectedItems)
                {
                    MoveExerciseToSession((lvi.Tag as Exercise).Id);
                }

                SaveSelectedExercisesToSession();
            }

            UpdateSessionStats();
        }

        private void _btnDeleteSessionExercise_Click(object sender, EventArgs e)
        {
            if (_lsvSessionExercises.SelectedItems.Count > 0)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Delete Exercises from session?", "Delete?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    List<ListViewItem> lvi = new List<ListViewItem>();
                    foreach (ListViewItem li in _lsvSessionExercises.SelectedItems)
                    {
                        lvi.Add(li);
                    }
                    foreach (ListViewItem li in lvi)
                    {
                        _lsvSessionExercises.Items.Remove(li);
                    }

                    SaveSelectedExercisesToSession();
                }
            }

            UpdateSessionStats();
        }
        private void SaveSelectedExercisesToSession()
        {
            Session s = GetSelectedSession();
            if (s != null)
            {
                s.Exercises.Clear();
                foreach (ListViewItem lvi in _lsvSessionExercises.Items)
                {
                    s.Exercises.Add((lvi.Tag as Exercise).Id);
                }
            }
        }
        private void _btnMoveExerciseUp_Click(object sender, EventArgs e)
        {
            if (_lsvSessionExercises.SelectedItems.Count == 1)
            {
                int sel = _lsvSessionExercises.SelectedIndices[0];
                if (sel - 1 >= 0)
                {
                    ListViewItem a = _lsvSessionExercises.Items[sel];
                    ListViewItem b = _lsvSessionExercises.Items[sel - 1];
                    SwapListViewItems(a, b);

                    _lsvSessionExercises.SelectedIndices.Clear();
                    _lsvSessionExercises.SelectedIndices.Add(sel - 1);

                    SaveSelectedExercisesToSession();
                }
            }
            UpdateSessionStats();
        }
        private void _btnMoveExerciseDown_Click(object sender, EventArgs e)
        {
            if (_lsvSessionExercises.SelectedItems.Count == 1)
            {
                int sel = _lsvSessionExercises.SelectedIndices[0];
                if (sel + 1 < _lsvSessionExercises.Items.Count)
                {
                    ListViewItem a = _lsvSessionExercises.Items[sel];
                    ListViewItem b = _lsvSessionExercises.Items[sel + 1];
                    SwapListViewItems(a, b);

                    _lsvSessionExercises.SelectedIndices.Clear();
                    _lsvSessionExercises.SelectedIndices.Add(sel + 1);

                    SaveSelectedExercisesToSession();
                }
            }
            UpdateSessionStats();
        }
        private void SwapListViewItems(ListViewItem a, ListViewItem b)
        {
            string tt = a.Text;
            a.Text = b.Text;
            b.Text = tt;
            Object te = a.Tag;
            a.Tag = b.Tag;
            b.Tag = te;
        }
        private void _lsvSessionExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            _btnMoveExerciseDown.Enabled =
                _btnMoveExerciseUp.Enabled =
                (_lsvSessionExercises.SelectedItems.Count == 1);

            UpdateSessionStats();
        }

        private void _txtName_TextChanged(object sender, EventArgs e)
        {
            //MarkChanged(true);
            Session s = GetSelectedSession();
            if (s != null)
            {
                s.Name = _txtName.Text;
            }
        }

        void MarkChanged(bool b)
        {
            _bChanged = b;
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            Globals.MainForm.SettingsForm.SaveData();
            Globals.MainForm.UpdateData();
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Globals.MainForm.SettingsForm.SaveData();
            Globals.MainForm.UpdateData();
            Close();
        }

        private void _txtName_Click(object sender, EventArgs e)
        {

        }

        private void _btnAddConfiguredExercise_Click(object sender, EventArgs e)
        {
            ExerciseEditorForm ef = new ExerciseEditorForm(AddEditMode.Add, null);
            DialogResult dr = ef.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Globals.MainForm.SettingsForm.Exercises.Add(ef.Exercise);
                RefreshConfiguredExercises();
            }

        }

        private void _btnEditConfiguredExercise_Click(object sender, EventArgs e)
        {
            if (_lsvConfiguredExercises.SelectedIndices.Count == 1)
            {
                ListViewItem item = _lsvConfiguredExercises.Items[_lsvConfiguredExercises.SelectedIndices[0]];
                Exercise exercise = item.Tag as Exercise;
                if (exercise != null)
                {
                    ExerciseEditorForm ef = new ExerciseEditorForm(AddEditMode.Edit, exercise);
                    ef.ShowDialog();
                    RefreshConfiguredExercises();

                }
            }
        }

        private void _btnRemoveConfiguredExercise_Click(object sender, EventArgs e)
        {
            if (_lsvConfiguredExercises.SelectedIndices.Count == 1)
            {
                ListViewItem item = _lsvConfiguredExercises.Items[_lsvConfiguredExercises.SelectedIndices[0]];
                Exercise exercise = item.Tag as Exercise;
                if (exercise != null)
                {
                    if (MessageBox.Show("Delete configured exercise? This Cannot be undone.",
                                        "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Globals.MainForm.SettingsForm.Exercises.Remove(exercise);
                        RefreshConfiguredExercises();
                    }

                }
            }
        }

        private void _txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                AcceptSessionName();
            }
        }
    }
}
