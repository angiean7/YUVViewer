namespace YuvImageShow
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_YUV420 = new System.Windows.Forms.RadioButton();
            this.button_YUV422 = new System.Windows.Forms.RadioButton();
            this.button_YUV444 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_RGB = new System.Windows.Forms.RadioButton();
            this.button_Y8 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_YUV420
            // 
            this.button_YUV420.AutoSize = true;
            this.button_YUV420.Location = new System.Drawing.Point(558, 17);
            this.button_YUV420.Name = "button_YUV420";
            this.button_YUV420.Size = new System.Drawing.Size(76, 19);
            this.button_YUV420.TabIndex = 1;
            this.button_YUV420.TabStop = true;
            this.button_YUV420.Text = "YUV420";
            this.button_YUV420.UseVisualStyleBackColor = true;
            // 
            // button_YUV422
            // 
            this.button_YUV422.AutoSize = true;
            this.button_YUV422.Location = new System.Drawing.Point(640, 17);
            this.button_YUV422.Name = "button_YUV422";
            this.button_YUV422.Size = new System.Drawing.Size(76, 19);
            this.button_YUV422.TabIndex = 2;
            this.button_YUV422.TabStop = true;
            this.button_YUV422.Text = "YUV422";
            this.button_YUV422.UseVisualStyleBackColor = true;
            // 
            // button_YUV444
            // 
            this.button_YUV444.AutoSize = true;
            this.button_YUV444.Location = new System.Drawing.Point(722, 17);
            this.button_YUV444.Name = "button_YUV444";
            this.button_YUV444.Size = new System.Drawing.Size(76, 19);
            this.button_YUV444.TabIndex = 3;
            this.button_YUV444.TabStop = true;
            this.button_YUV444.Text = "YUV444";
            this.button_YUV444.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 25);
            this.textBox1.TabIndex = 4;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(441, 13);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 5;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_convert
            // 
            this.button_convert.BackColor = System.Drawing.Color.Plum;
            this.button_convert.Location = new System.Drawing.Point(930, 15);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 6;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = false;
            this.button_convert.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_RGB
            // 
            this.button_RGB.AutoSize = true;
            this.button_RGB.Location = new System.Drawing.Point(804, 17);
            this.button_RGB.Name = "button_RGB";
            this.button_RGB.Size = new System.Drawing.Size(52, 19);
            this.button_RGB.TabIndex = 7;
            this.button_RGB.TabStop = true;
            this.button_RGB.Text = "RGB";
            this.button_RGB.UseVisualStyleBackColor = true;
            // 
            // button_Y8
            // 
            this.button_Y8.AutoSize = true;
            this.button_Y8.Location = new System.Drawing.Point(862, 17);
            this.button_Y8.Name = "button_Y8";
            this.button_Y8.Size = new System.Drawing.Size(44, 19);
            this.button_Y8.TabIndex = 8;
            this.button_Y8.TabStop = true;
            this.button_Y8.Text = "Y8";
            this.button_Y8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1062, 973);
            this.Controls.Add(this.button_Y8);
            this.Controls.Add(this.button_RGB);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_YUV444);
            this.Controls.Add(this.button_YUV422);
            this.Controls.Add(this.button_YUV420);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "ImageShow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton button_YUV420;
        private System.Windows.Forms.RadioButton button_YUV422;
        private System.Windows.Forms.RadioButton button_YUV444;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.RadioButton button_RGB;
        private System.Windows.Forms.RadioButton button_Y8;
    }
}

