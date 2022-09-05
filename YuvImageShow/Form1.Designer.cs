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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_YUV420 = new System.Windows.Forms.RadioButton();
            this.button_YUV422 = new System.Windows.Forms.RadioButton();
            this.button_YUV444 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_RGB = new System.Windows.Forms.RadioButton();
            this.button_Y8 = new System.Windows.Forms.RadioButton();
            this.button_convert = new System.Windows.Forms.Button();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_YUV420
            // 
            this.button_YUV420.AutoSize = true;
            this.button_YUV420.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_YUV420.Location = new System.Drawing.Point(9, 34);
            this.button_YUV420.Margin = new System.Windows.Forms.Padding(2);
            this.button_YUV420.Name = "button_YUV420";
            this.button_YUV420.Size = new System.Drawing.Size(59, 16);
            this.button_YUV420.TabIndex = 1;
            this.button_YUV420.TabStop = true;
            this.button_YUV420.Text = "YUV420";
            this.button_YUV420.UseVisualStyleBackColor = true;
            // 
            // button_YUV422
            // 
            this.button_YUV422.AutoSize = true;
            this.button_YUV422.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_YUV422.Location = new System.Drawing.Point(71, 34);
            this.button_YUV422.Margin = new System.Windows.Forms.Padding(2);
            this.button_YUV422.Name = "button_YUV422";
            this.button_YUV422.Size = new System.Drawing.Size(59, 16);
            this.button_YUV422.TabIndex = 2;
            this.button_YUV422.TabStop = true;
            this.button_YUV422.Text = "YUV422";
            this.button_YUV422.UseVisualStyleBackColor = true;
            // 
            // button_YUV444
            // 
            this.button_YUV444.AutoSize = true;
            this.button_YUV444.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_YUV444.Location = new System.Drawing.Point(134, 34);
            this.button_YUV444.Margin = new System.Windows.Forms.Padding(2);
            this.button_YUV444.Name = "button_YUV444";
            this.button_YUV444.Size = new System.Drawing.Size(59, 16);
            this.button_YUV444.TabIndex = 3;
            this.button_YUV444.TabStop = true;
            this.button_YUV444.Text = "YUV444";
            this.button_YUV444.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.textBox1.Location = new System.Drawing.Point(9, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 21);
            this.textBox1.TabIndex = 4;
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_browse.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_browse.Location = new System.Drawing.Point(288, 9);
            this.button_browse.Margin = new System.Windows.Forms.Padding(2);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(56, 18);
            this.button_browse.TabIndex = 5;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_RGB
            // 
            this.button_RGB.AutoSize = true;
            this.button_RGB.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_RGB.Location = new System.Drawing.Point(194, 34);
            this.button_RGB.Margin = new System.Windows.Forms.Padding(2);
            this.button_RGB.Name = "button_RGB";
            this.button_RGB.Size = new System.Drawing.Size(41, 16);
            this.button_RGB.TabIndex = 7;
            this.button_RGB.TabStop = true;
            this.button_RGB.Text = "RGB";
            this.button_RGB.UseVisualStyleBackColor = true;
            // 
            // button_Y8
            // 
            this.button_Y8.AutoSize = true;
            this.button_Y8.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_Y8.Location = new System.Drawing.Point(237, 34);
            this.button_Y8.Margin = new System.Windows.Forms.Padding(2);
            this.button_Y8.Name = "button_Y8";
            this.button_Y8.Size = new System.Drawing.Size(35, 16);
            this.button_Y8.TabIndex = 8;
            this.button_Y8.TabStop = true;
            this.button_Y8.Text = "Y8";
            this.button_Y8.UseVisualStyleBackColor = true;
            // 
            // button_convert
            // 
            this.button_convert.BackColor = System.Drawing.Color.HotPink;
            this.button_convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_convert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_convert.Location = new System.Drawing.Point(288, 34);
            this.button_convert.Margin = new System.Windows.Forms.Padding(2);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(56, 18);
            this.button_convert.TabIndex = 6;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = false;
            this.button_convert.Click += new System.EventHandler(this.button2_Click);
            // 
            // WidthBox
            // 
            this.WidthBox.ForeColor = System.Drawing.Color.DeepPink;
            this.WidthBox.Location = new System.Drawing.Point(367, 33);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(55, 21);
            this.WidthBox.TabIndex = 11;
            // 
            // HeightBox
            // 
            this.HeightBox.ForeColor = System.Drawing.Color.DeepPink;
            this.HeightBox.Location = new System.Drawing.Point(425, 33);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(55, 21);
            this.HeightBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(364, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(421, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(491, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.button_Y8);
            this.Controls.Add(this.button_RGB);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_YUV444);
            this.Controls.Add(this.button_YUV422);
            this.Controls.Add(this.button_YUV420);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ImageShow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton button_YUV420;
        private System.Windows.Forms.RadioButton button_YUV422;
        private System.Windows.Forms.RadioButton button_YUV444;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.RadioButton button_RGB;
        private System.Windows.Forms.RadioButton button_Y8;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

