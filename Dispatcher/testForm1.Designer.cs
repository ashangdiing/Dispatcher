namespace Dispatcher
{
    partial class testForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testControl11 = new Dispatcher.testControl1();
            this.SuspendLayout();
            // 
            // testControl11
            // 
            this.testControl11.AutoSize = true;
            this.testControl11.Location = new System.Drawing.Point(12, 12);
            this.testControl11.Name = "testControl11";
            this.testControl11.Size = new System.Drawing.Size(483, 167);
            this.testControl11.TabIndex = 0;
            // 
            // testForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(892, 262);
            this.Controls.Add(this.testControl11);
            this.Name = "testForm1";
            this.Text = "testForm1";
            this.Load += new System.EventHandler(this.testForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testControl1 testControl11;




    }
}