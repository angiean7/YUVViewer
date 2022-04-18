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
                    
                    Bitmap bmp = new Bitmap(176, 144, PixelFormat.Format24bppRgb);
                    BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);

                    byte[] newImgData = ColorYuvToRgbImage(buffer, (int)file.Length);
                    //Bitmap bmp = new Bitmap(pathname);
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



                    //Image img = Image.FromHbitmap(bmp.GetHbitmap());
                    pictureBox1.Image = bmp;
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
