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
            this.listBox__fibonacci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox__fibonacci
            // 
            this.listBox__fibonacci.FormattingEnabled = true;
            this.listBox__fibonacci.ItemHeight = 15;
            this.listBox__fibonacci.Location = new System.Drawing.Point(158, 95);
            this.listBox__fibonacci.Name = "listBox__fibonacci";
            this.listBox__fibonacci.Size = new System.Drawing.Size(120, 94);
            this.listBox__fibonacci.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox__fibonacci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox__fibonacci;
    }
}