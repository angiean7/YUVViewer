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


        private string pathname = string.Empty;     		
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            openDlg = new OpenFileDialog();
            openDlg.Filter = "YUV文件|*.*";
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

        static double[,] YUV2RGB_CONVERT_MATRIX = new double[3, 3] { { 1, 0, 1.4022 }, { 1, -0.3456, -0.7145 }, { 1, 1.771, 0 } };

        private unsafe byte[] ColorYuv444ToRgbImage_c(byte[] I0, long bufferLength, int image_width, int height)
        {
            int x;
            byte[] J0 = new byte[bufferLength * 6 / 4];

            //Process two Y,U,V triples per iteration:
            for (x = 0; x < image_width; x += 2)
            {
                //Load source elements
                byte y0 = I0[x * 3];                  //Load source Y element
                int u0 = (int)I0[x * 3 + 1];  //Load source U element (and convert from uint8 to uint32).
                int v0 = (int)I0[x * 3 + 2];  //Load source V element (and convert from uint8 to uint32).

            //Load next source elements
            byte y1 = I0[x * 3 + 3];                //Load source Y element
            int u1 = (int)I0[x * 3 + 4];  //Load source U element (and convert from uint8 to uint32).
            int v1 = (int)I0[x * 3 + 5];  //Load source V element (and convert from uint8 to uint32).

            //Calculate destination U, and V elements.
            //Use shift right by 1 for dividing by 2.
            //Use plus 1 before shifting - round operation instead of floor operation.
            int u01 = (u0 + u1 + 1) >> 1;       //Destination U element equals average of two source U elements.
            int v01 = (v0 + v1 + 1) >> 1;       //Destination U element equals average of two source U elements.

            J0[x * 2] = y0;   //Store Y element (unmodified).
            J0[x * 2 + 1] = (byte)u01;   //Store destination U element (and cast uint32 to uint8).
            J0[x * 2 + 2] = y1;   //Store Y element (unmodified).
            J0[x * 2 + 3] = (byte)v01;   //Store destination V element (and cast uint32 to uint8).
            }
            return J0;
        }
        private unsafe byte[] ColorYuv444ToRgbImage(byte[] yuvFrame, long bufferLength, int width, int height)
        {
            int uIndex = width * height;
            int vIndex = uIndex + ((width * height) >> 2);
            int gIndex = width * height;
            int bIndex = gIndex * 2;

            int temp = 0;
            byte[] rgbFrame = new byte[bufferLength * 6 / 4];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // R分量
                    temp = (int)(yuvFrame[y * width + x] + (yuvFrame[vIndex + (y / 2) * (width / 2) + x / 2] - 128) * YUV2RGB_CONVERT_MATRIX[0, 2]);
                    rgbFrame[y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));

                    // G分量
                    temp = (int)(yuvFrame[y * width + x] + (yuvFrame[uIndex + (y / 2) * (width / 2) + x / 2] - 128) * YUV2RGB_CONVERT_MATRIX[1, 1] + (yuvFrame[vIndex + (y / 2) * (width / 2) + x / 2] - 128) * YUV2RGB_CONVERT_MATRIX[1, 2]);
                    rgbFrame[gIndex + y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));

                    // B分量
                    temp = (int)(yuvFrame[y * width + x] + (yuvFrame[uIndex + (y / 2) * (width / 2) + x / 2] - 128) * YUV2RGB_CONVERT_MATRIX[2, 1]);
                    rgbFrame[bIndex + y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                }
            }
            return rgbFrame;
        }

        private unsafe byte[] ColorYuvToRgbImage(IntPtr buffer, long bufferLength)
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

                int pixel_R = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 1596 * (pixel_cr - 128)));
                int pixel_G = GetPixelValue((int)(1164 * (pixel_y1 - 16) - 813 * (pixel_cr - 128) - 391 * (pixel_cb - 128)));
                int pixel_B = GetPixelValue((int)(1164 * (pixel_y1 - 16) + 2018 * (pixel_cb - 128)));
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (openDlg.FileName != string.Empty)
            {
                try
                {
                    pathname = openDlg.FileName;
                    FileStream file = File.Open(pathname, FileMode.Open);
                    byte[] b_buffer = new byte[file.Length];
                    file.Read(b_buffer, 0, (int)file.Length);

                    IntPtr buffer = Marshal.AllocHGlobal((IntPtr)file.Length);
                    buffer = System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(b_buffer, 0);
                    
                    if(radioButton1.Checked)
                    {
                        //YUV420
                    }
                    else if (radioButton2.Checked)
                    {
                        //YUV422
                        Bitmap bmp = new Bitmap(1920, 1080, PixelFormat.Format24bppRgb);
                        BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);

                        byte[] newImgData = ColorYuvToRgbImage(buffer, (int)file.Length);
                        //Bitmap bmp = new Bitmap(pathname);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            //for (int len = 0; len < newImgData.Length; len++)
                            for (int len = 0; len < file.Length; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }
                    else if (radioButton3.Checked)
                    {
                        //YUV444
                        Bitmap bmp = new Bitmap(176, 144, PixelFormat.Format24bppRgb);
                        BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);

                        byte[] newImgData = ColorYuv444ToRgbImage_c(b_buffer, (int)file.Length, 176, 144);
                        unsafe
                        {
                            byte* pNative = (byte*)bmpData.Scan0;
                            //for (int len = 0; len < newImgData.Length; len++)
                            for (int len = 0; len < 0x13000; len++)
                            {
                                pNative[len] = newImgData[len];
                            }
                        }
                        bmp.UnlockBits(bmpData);
                        pictureBox1.Image = bmp;
                    }

                    



                    //Image img = Image.FromHbitmap(bmp.GetHbitmap());
                    pictureBox1.Show();
                    pictureBox1.Refresh();

                    //this.pictureBox1.Load(pathname);
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
