namespace ASP.NET_MVC_Core
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_fibonacci = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.timer_slide = new System.Windows.Forms.TrackBar();
            this.text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.timer_slide)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(74, 125);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(120, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_fibonacci
            // 
            this.textBox_fibonacci.Location = new System.Drawing.Point(74, 87);
            this.textBox_fibonacci.Name = "textBox_fibonacci";
            this.textBox_fibonacci.Size = new System.Drawing.Size(541, 23);
            this.textBox_fibonacci.TabIndex = 3;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(637, 87);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(129, 23);
            this.textBox_time.TabIndex = 4;
            // 
            // timer_slide
            // 
            this.timer_slide.Location = new System.Drawing.Point(510, 125);
            this.timer_slide.Maximum = 10000;
            this.timer_slide.Minimum = 200;
            this.timer_slide.Name = "timer_slide";
            this.timer_slide.Size = new System.Drawing.Size(256, 45);
            this.timer_slide.SmallChange = 5;
            this.timer_slide.TabIndex = 200;
            this.timer_slide.Value = 2000;
            this.timer_slide.Scroll += new System.EventHandler(this.timer_slide_Scroll);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(641, 170);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(100, 23);
            this.text.TabIndex = 201;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.timer_slide);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_fibonacci);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timer_slide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_start;
        private TextBox textBox_fibonacci;
        private TextBox textBox_time;
        private TrackBar timer_slide;
        private TextBox text;
    }
}