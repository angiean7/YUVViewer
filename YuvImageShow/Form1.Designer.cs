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
            this.button_YUV420 = new System.Windows.Forms.RadioButton();
            this.button_YUV422 = new System.Windows.Forms.RadioButton();
            this.button_YUV444 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_RGB = new System.Windows.Forms.RadioButton();
            this.button_Y8 = new System.Windows.Forms.RadioButton();
            this.size_box = new System.Windows.Forms.ComboBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_YUV420
            // 
            this.button_YUV420.AutoSize = true;
            this.button_YUV420.Location = new System.Drawing.Point(418, 14);
            this.button_YUV420.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button_YUV422.Location = new System.Drawing.Point(480, 14);
            this.button_YUV422.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button_YUV444.Location = new System.Drawing.Point(542, 14);
            this.button_YUV444.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_YUV444.Name = "button_YUV444";
            this.button_YUV444.Size = new System.Drawing.Size(59, 16);
            this.button_YUV444.TabIndex = 3;
            this.button_YUV444.TabStop = true;
            this.button_YUV444.Text = "YUV444";
            this.button_YUV444.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 21);
            this.textBox1.TabIndex = 4;
            // 
            // button_browse
            // 
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_browse.Location = new System.Drawing.Point(331, 10);
            this.button_browse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(56, 18);
            this.button_browse.TabIndex = 5;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_RGB
            // 
            this.button_RGB.AutoSize = true;
            this.button_RGB.Location = new System.Drawing.Point(603, 14);
            this.button_RGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button_Y8.Location = new System.Drawing.Point(646, 14);
            this.button_Y8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Y8.Name = "button_Y8";
            this.button_Y8.Size = new System.Drawing.Size(35, 16);
            this.button_Y8.TabIndex = 8;
            this.button_Y8.TabStop = true;
            this.button_Y8.Text = "Y8";
            this.button_Y8.UseVisualStyleBackColor = true;
            // 
            // size_box
            // 
            this.size_box.FormattingEnabled = true;
            this.size_box.Items.AddRange(new object[] {
            "1920*1020"});
            this.size_box.Location = new System.Drawing.Point(684, 11);
            this.size_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(92, 20);
            this.size_box.TabIndex = 9;
            // 
            // button_convert
            // 
            this.button_convert.BackColor = System.Drawing.Color.Gainsboro;
            this.button_convert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_convert.Location = new System.Drawing.Point(790, 11);
            this.button_convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(56, 18);
            this.button_convert.TabIndex = 6;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = false;
            this.button_convert.Click += new System.EventHandler(this.button2_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Gainsboro;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Display.Location = new System.Drawing.Point(790, 33);
            this.Display.Margin = new System.Windows.Forms.Padding(2);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(56, 18);
            this.Display.TabIndex = 10;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(898, 778);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.size_box);
            this.Controls.Add(this.button_Y8);
            this.Controls.Add(this.button_RGB);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_YUV444);
            this.Controls.Add(this.button_YUV422);
            this.Controls.Add(this.button_YUV420);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox size_box;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button Display;
    }
}

