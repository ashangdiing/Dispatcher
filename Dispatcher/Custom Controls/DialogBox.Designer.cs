namespace Dispatcher.Custom_Controls
{
    partial class DialogBox
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
            this.passWordDialogBoxPanel = new Dispatcher.Custom_Controls.PassWordDialogBox();
            this.SuspendLayout();
            // 
            // passWordDialogBoxPanel
            // 
            this.passWordDialogBoxPanel.Location = new System.Drawing.Point(81, 2);
            this.passWordDialogBoxPanel.Name = "passWordDialogBoxPanel";
            this.passWordDialogBoxPanel.Size = new System.Drawing.Size(283, 365);
            this.passWordDialogBoxPanel.TabIndex = 0;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 419);
            this.Controls.Add(this.passWordDialogBoxPanel);
            this.MaximizeBox = false;
            this.Name = "DialogBox";
            this.Text = "对话框";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogBox_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogBox_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private PassWordDialogBox passWordDialogBoxPanel;
    }
}