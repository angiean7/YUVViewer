using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace YuvImageShow
{

    public partial class Form1 : Form
    {
        public OpenFileDialog openDlg;
        public Form1()
        {
            InitializeComponent();
        }
  		
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openDlg = new OpenFileDialog();
            openDlg.Filter = "bin文件|*.*";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openDlg.FileName;
            }      
        }

        private int GetPixelValue(int pixelValue)
        {
            if (pixelValue >= 0 && pixelValue <= 255000)
                pixelValue = pixelValue / 1000;
            else
                pixelValue = (pixelValue < 0) ? 0 : 255;
            return pixelValue;
        }

        private unsafe byte[] ColorYuv420ToRgbImage(IntPtr buffer, long bufferLength)
        {
            int pixel_width = 1920;
            int YUV_width = pixel_width*3/2;
            
            IntPtr pImageData = buffer;
            long nLength = bufferLength;
            byte[] RgbImgData = new byte[nLength * 2];
            byte pixel_y0 = 0;
            byte pixel_cb_0 = 0;
            byte pixel_y1 = 0;
            byte pixel_y1920 = 0;
            byte pixel_cr_0 = 0;
            byte pixel_y1921 = 0;
            int iYuvOff = 0;
            int iRgbOff = 0;
            int i=0;

            byte* pbtYuvImageData = (byte*)pImageData;

            for (iYuvOff = 0; (iYuvOff+YUV_width*2) < nLength; iYuvOff += YUV_width*2)
            {
                for(i = 0; i < (YUV_width/3); i++)
                {
                    pixel_y0    = *(pbtYuvImageData + iYuvOff + 0 + i*3);
                    pixel_cb_0  = *(pbtYuvImageData + iYuvOff + 1 + i*3);//u0
                    pixel_y1    = *(pbtYuvImageData + iYuvOff + 2 + i*3);

                    pixel_y1920 = *(pbtYuvImageData + iYuvOff + YUV_width + 0 + i*3);
                    pixel_cr_0  = *(pbtYuvImageData + iYuvOff + YUV_width + 1 + i*3);//v0
                    pixel_y1921 = *(pbtYuvImageData + iYuvOff + YUV_width + 2 + i*3);

                    int pixel_R = GetPixelValue((int)(1164 * (pixel_y0 - 16) + 1596 * (pixel_cr_0 - 128)));
                    int pixel_G = GetPixelValue((int)(1164 * (pixel_y0 - 16) - 813  * (pixel_cr_0 - 128) - 391 * (pixel_cb_0 - 128)));
                    int pixel_B = GetPixelValue((int)(1164 * (pixel_y0 - 16) + 2018 * (pixel_cb_0 - 128)));
                    RgbImgData[iRgbOff + 0] = (byte)pixel_B;
                    RgbImgData[iRgbOff + 1] = (byte)pixel_G;
                    RgbImgData[iRgbOff + 2] = (byte)pixel_R;

                    pixel_R = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 1596 * (pixel_cr_0 - 128)));
                    pixel_G = GetPixelValue((int)(1164 * (pixel_y1 - 16) - 813  * (pixel_cr_0 - 128) - 391 * (pixel_cb_0 - 128)));
                    pixel_B = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 2018 * (pixel_cb_0 - 128)));
                    RgbImgData[iRgbOff + 3] = (byte)pixel_B;
                    RgbImgData[iRgbOff + 4] = (byte)pixel_G;
                    RgbImgData[iRgbOff + 5] = (byte)pixel_R;
                    
                    pixel_R = GetPixelValue((int)(1164 * (pixel_y1920 - 16) + 1596 * (pixel_cr_0 - 128)));
                    pixel_G = GetPixelValue((int)(1164 * (pixel_y1920 - 16) - 813  * (pixel_cr_0 - 128) - 391 * (pixel_cb_0 - 128)));
                    pixel_B = GetPixelValue((int)(1164 * (pixel_y1920 - 16) + 2018 * (pixel_cb_0 - 128)));
                    RgbImgData[iRgbOff + (pixel_width*3) + 0] = (byte)pixel_B;
                    RgbImgData[iRgbOff + (pixel_width*3) + 1] = (byte)pixel_G;
                    RgbImgData[iRgbOff + (pixel_width*3) + 2] = (byte)pixel_R;

                    pixel_R = GetPixelValue((int)(1164 * (pixel_y1921 - 16) + 1596 * (pixel_cr_0 - 128)));
                    pixel_G = GetPixelValue((int)(1164 * (pixel_y1921 - 16) - 813  * (pixel_cr_0 - 128) - 391 * (pixel_cb_0 - 128)));
                    pixel_B = GetPixelValue((int)(1164 * (pixel_y1921 - 16) + 2018 * (pixel_cb_0 - 128)));
                    RgbImgData[iRgbOff + (pixel_width*3) + 3] = (byte)pixel_B;
                    RgbImgData[iRgbOff + (pixel_width*3) + 4] = (byte)pixel_G;
                    RgbImgData[iRgbOff + (pixel_width*3) + 5] = (byte)pixel_R;

                    iRgbOff = iRgbOff + 6;
                }
                iRgbOff += (pixel_width*3);
            }
            return RgbImgData;
        }

        private unsafe byte[] GrayYuvToRgbImage(IntPtr buffer, long bufferLength)
        {
            IntPtr pImageData = buffer;
            long nLength = bufferLength;
            byte[] RgbImgData = new byte[nLength * 3];
            byte pixel_y0 = 0;
            int iYuvOff = 0;
            int iRgbOff = 0;
            byte* pbtYuvImageData = (byte*)pImageData;

            for (iYuvOff = 0; iYuvOff < nLength; iYuvOff++)
            {
                pixel_y0 = *(pbtYuvImageData + iYuvOff);
                int pixelValue = GetPixelValue((int)(1164 * (pixel_y0 - 16)));
                RgbImgData[iRgbOff + 0] = (byte)pixelValue;
                RgbImgData[iRgbOff + 1] = (byte)pixelValue;
                RgbImgData[iRgbOff + 2] = (byte)pixelValue;
                iRgbOff = iRgbOff + 3;
            }
            return RgbImgData;
        }

        private unsafe byte[] ColorYuv444ToRgbImage(IntPtr buffer, long bufferLength)
        {
            IntPtr pImageData = buffer;
            byte yuv_pixel_Y;
            byte yuv_pixel_U;
            byte yuv_pixel_V;
            int rgb_pixel_R = 0;
            int rgb_pixel_G = 0;
            int rgb_pixel_B = 0;
            int iYuvOff = 0;
            int iRgbOff = 0;
            byte[] RgbImgData = new byte[bufferLength];
            byte* pbtYuvImageData = (byte*)pImageData;

            for (iYuvOff = 0; iYuvOff < bufferLength; iYuvOff += 3)
            {
                yuv_pixel_Y = *(pbtYuvImageData + iYuvOff + 0);
                yuv_pixel_U = *(pbtYuvImageData + iYuvOff + 1);
                yuv_pixel_V = *(pbtYuvImageData + iYuvOff + 2);

                rgb_pixel_R = GetPixelValue((int)(1164 * (yuv_pixel_Y - 16) + 1596 * (yuv_pixel_V - 128)));
                rgb_pixel_G = GetPixelValue((int)(1164 * (yuv_pixel_Y - 16) - 813 * (yuv_pixel_V - 128) - 391 * (yuv_pixel_U - 128)));
                rgb_pixel_B = GetPixelValue((int)(1164 * (yuv_pixel_Y - 16) + 2018 * (yuv_pixel_U - 128)));

                RgbImgData[iRgbOff + 0] = (byte)rgb_pixel_B;
                RgbImgData[iRgbOff + 1] = (byte)rgb_pixel_G;
                RgbImgData[iRgbOff + 2] = (byte)rgb_pixel_R;

                iRgbOff = iRgbOff + 3;
            }

            return RgbImgData;
        }

        private unsafe byte[] ColorYuv422ToRgbImage(IntPtr buffer, long bufferLength)
        {
            IntPtr pImageData = buffer;
            long nLength = bufferLength;
            byte[] RgbImgData = new byte[nLength * 6 / 4];
            byte pixel_y0 = 0;
            byte pixel_cb = 0;
            byte pixel_y1 = 0;
            byte pixel_cr = 0;
            int iYuvOff = 0;
            int iRgbOff = 0;

            byte* pbtYuvImageData = (byte*)pImageData;

            for (iYuvOff = 0; iYuvOff < nLength; iYuvOff += 4)
            {
                pixel_y0 = *(pbtYuvImageData + iYuvOff + 0);
                pixel_cb = *(pbtYuvImageData + iYuvOff + 1);//u
                pixel_y1 = *(pbtYuvImageData + iYuvOff + 2);
                pixel_cr = *(pbtYuvImageData + iYuvOff + 3);//v

                int pixel_R = GetPixelValue((int)(1164 * (pixel_y0 - 16) + 1596 * (pixel_cr - 128)));
                int pixel_G = GetPixelValue((int)(1164 * (pixel_y0 - 16) - 813 * (pixel_cr - 128) - 391 * (pixel_cb - 128)));
                int pixel_B = GetPixelValue((int)(1164 * (pixel_y0 - 16) + 2018 * (pixel_cb - 128)));
                RgbImgData[iRgbOff + 0] = (byte)pixel_B;
                RgbImgData[iRgbOff + 1] = (byte)pixel_G;
                RgbImgData[iRgbOff + 2] = (byte)pixel_R;

                pixel_R = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 1596 * (pixel_cr - 128)));
                pixel_G = GetPixelValue((int)(1164 * (pixel_y1 - 16) - 813 * (pixel_cr - 128) - 391 * (pixel_cb - 128)));
                pixel_B = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 2018 * (pixel_cb - 128)));
                RgbImgData[iRgbOff + 3] = (byte)pixel_B;
                RgbImgData[iRgbOff + 4] = (byte)pixel_G;
                RgbImgData[iRgbOff + 5] = (byte)pixel_R;

                iRgbOff = iRgbOff + 6;
            }
            return RgbImgData;
        }

        private string pathname = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            if (openDlg.FileName != string.Empty)
            {
                try
                {
                    //open file and get buffer
                    pathname = openDlg.FileName;
                    FileStream file = File.Open(pathname, FileMode.Open);
                    byte[] b_buffer = new byte[file.Length];
                    file.Read(b_buffer, 0, (int)file.Length);

                    IntPtr buffer = Marshal.AllocHGlobal((IntPtr)file.Length);
                    buffer = System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(b_buffer, 0);

                    Bitmap bmp = new Bitmap(1920, 1080, PixelFormat.Format24bppRgb);
                    //Bitmap bmp = new Bitmap(176, 144, PixelFormat.Format24bppRgb);
                    BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);


                    if (button_YUV420.Checked)
                    {
                        //YUV420
                        byte[] newImgData = ColorYuv420ToRgbImage(buffer, (int)file.Length);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            //for (int len = 0; len < newImgData.Length; len++)
                            for (int len = 0; len < 6220800; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    else if (button_YUV422.Checked)
                    {
                        //YUV422
                        byte[] newImgData = ColorYuv422ToRgbImage(buffer, (int)file.Length);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            for (int len = 0; len < newImgData.Length; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    else if (button_YUV444.Checked)
                    {
                        //YUV444
                        byte[] newImgData = ColorYuv444ToRgbImage(buffer, (int)file.Length);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0; 
                            for (int len = 0; len < newImgData.Length; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    else if (button_RGB.Checked)
                    {
                        //RGB
                        byte[] newImgData = b_buffer;
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            for (int len = 0; len < newImgData.Length; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    else if (button_Y8.Checked)
                    {
                        //Y8
                        byte[] newImgData = GrayYuvToRgbImage(buffer, (int)file.Length);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            for (int len = 0; len < newImgData.Length; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    
                    pictureBox1.Show();
                    pictureBox1.Refresh();
                    file.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
