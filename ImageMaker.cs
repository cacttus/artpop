using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
namespace ArtPop
{
   /// <summary>
   /// 
   /// This is copied from Monogame Toolkit **DO NOT USE**
   /// </summary>
    public struct Pixel
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;
        public Pixel(byte xr, byte xg, byte xb, byte xa)
        {
            r = xr;
            g = xg;
            b = xb;
            a = xa;
        }
    }
    public class ImageMaker
    {
        public Bitmap Bitmap { get; private set; } = null;
        public byte[] Data { get; set; } = null;
        public int Stride { get; private set; } = 0;
        public bool Locked { get; private set; } = false;

        public ImageMaker(Bitmap bmp)
        {
            Bitmap = bmp;
        }

        #region Ops
        public ImageMaker Colorize(Pixel pix, byte alpha_threshold=0)
        {
            //Turn all visible pixels into the specified color.
            ModifyPixelData((ImageMaker) =>
            {
                PixelOp((int x, int y, Pixel p) => {
                    if(p.a > alpha_threshold)
                    {
                        SetPixel(x, y, new Pixel(pix.r, pix.g, pix.b, p.a));
                    }
                });
            });

            return this;
        }
        public ImageMaker BlackAndWhite()
        {
            ModifyPixelData((ImageMaker) =>
            {
                PixelOp((int x, int y, Pixel p) => {
                    double f = .299 * (double)p.r + .587 * (double)p.g + .114 * (double)p.b;
                    SetPixel(x, y, new Pixel((byte)f, (byte)f, (byte)f, p.a));
                });
            });

            return this;
        }
        public ImageMaker SetAlpha(float alpha)
        {
            //Set alpha channel (fade image)
            byte a = (byte)(255 * alpha);
            ModifyPixelData((ImageMaker) =>
            {
                PixelOp((int x, int y, Pixel p) => {
                    SetPixel(x, y, new Pixel(p.r, p.g, p.b, a));
                });
            });

            return this;
        }
        #endregion

        #region Base

        public void PixelOp(Action<int, int, Pixel> op)
        {
            for (int y = 0; y < Bitmap.Height; ++y)
            {
                for (int x = 0; x < Bitmap.Width; ++x)
                {
                    op(x, y, GetPixel(x, y));
                }
            }
        }

        public Pixel GetPixel(int x, int y)
        {
            if (Locked == false)
            {
                throw new Exception("Bitmap was not locked");
            }

            Pixel pix = new Pixel();
            int iOff = y * Bitmap.Width * Stride + x * Stride;

            if (Stride == 4)
            {
                pix.r = Data[iOff + 0];
                pix.g = Data[iOff + 1];
                pix.b = Data[iOff + 2];
                pix.a = Data[iOff + 3];
            }
            else if (Stride == 3)
            {
                pix.r = Data[iOff + 0];
                pix.g = Data[iOff + 1];
                pix.b = Data[iOff + 2];
            }
            else
            {
                throw new Exception("Invalid stride for image: Stride=" + Stride);
            }

            return pix;
        }
        public void SetPixel(int x, int y, Pixel pix)
        {
            if (Locked == false)
            {
                throw new Exception("Bitmap was not locked");
            }

            int iOff = y * Bitmap.Width * Stride + x * Stride;

            if (Stride == 4)
            {
                Data[iOff + 0] = pix.r;
                Data[iOff + 1] = pix.g;
                Data[iOff + 2] = pix.b;
                Data[iOff + 3] = pix.a;
            }
            else if (Stride == 3)
            {
                Data[iOff + 0] = pix.r;
                Data[iOff + 1] = pix.g;
                Data[iOff + 2] = pix.b;
            }
            else
            {
                throw new Exception("Invalid stride for image: Stride=" + Stride);
            }
        }

        private void ModifyPixelData(Action<ImageMaker> action)
        {
            // Lock the bitmap's bits. 
            BitmapData bmpData = null;
            try
            {
                Rectangle rect = new Rectangle(0, 0, Bitmap.Width, Bitmap.Height);
                bmpData = Bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, Bitmap.PixelFormat);
                {
                    Locked = true;
                    {
                        // Get the address of the first line.
                        IntPtr ptr = bmpData.Scan0;

                        // Declare an array to hold the bytes of the bitmap.
                        int numBytes = Math.Abs(bmpData.Stride) * Bitmap.Height;
                        Data = new byte[numBytes];

                        int fmt_size = Image.GetPixelFormatSize(Bitmap.PixelFormat);
                        if (fmt_size == 32)
                        {
                            Stride = 4;
                        }
                        else if (fmt_size == 24)
                        {
                            Stride = 3;
                        }
                        else
                        {
                            throw new Exception("Invalid pixel format size for image: size=" + fmt_size);
                        }

                        // Copy the RGB values into the array.
                        System.Runtime.InteropServices.Marshal.Copy(ptr, Data, 0, numBytes);

                        //Run action
                        action(this);

                        // Copy the RGB values back to the bitmap
                        System.Runtime.InteropServices.Marshal.Copy(Data, 0, ptr, numBytes);
                    }
                    Locked = false;
                }
                // Unlock the bits.
                Bitmap.UnlockBits(bmpData);
            }
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
                Locked = false;
                if (bmpData != null)
                {
                    try
                    {
                        Bitmap.UnlockBits(bmpData);
                    }
                    catch (Exception ex2)
                    {
                        Globals.LogError(ex2.ToString());
                    }
                }

            }
        }
        #endregion




    }



}
