using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuvImageShow
{
    public partial class imageShow : Form
    {
        public imageShow()
        {
            InitializeComponent();
        }

        private void imageShow_Load(object sender, EventArgs e)
        {

        }

        public PictureBox GetPictureBox()
        {
            return pictureBox1;
        }
    }
}
