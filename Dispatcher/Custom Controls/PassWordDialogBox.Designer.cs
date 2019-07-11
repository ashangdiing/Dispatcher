namespace Dispatcher.Custom_Controls
{
    partial class PassWordDialogBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomNameText = new System.Windows.Forms.TextBox();
            this.managerPasswordBox = new System.Windows.Forms.TextBox();
            this.managerPasswordlabel = new System.Windows.Forms.Label();
            this.enterPasswordBox = new System.Windows.Forms.TextBox();
            this.enterPasswordlabel = new System.Windows.Forms.Label();
            this.listeningPasswordBox = new System.Windows.Forms.TextBox();
            this.listeningPasswordlabel = new System.Windows.Forms.Label();
            this.comperePasswordBox = new System.Windows.Forms.TextBox();
            this.comperePasswordlabel = new System.Windows.Forms.Label();
            this.maxPersonOfNumbertextBox = new System.Windows.Forms.TextBox();
            this.maxPersonOfNumberlabel = new System.Windows.Forms.Label();
            this.roomInfoSubmit = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(40, 27);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(53, 12);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "房间名：";
            // 
            // roomNameText
            // 
            this.roomNameText.Location = new System.Drawing.Point(104, 24);
            this.roomNameText.Name = "roomNameText";
            this.roomNameText.Size = new System.Drawing.Size(143, 21);
            this.roomNameText.TabIndex = 1;
            // 
            // managerPasswordBox
            // 
            this.managerPasswordBox.Location = new System.Drawing.Point(104, 68);
            this.managerPasswordBox.Name = "managerPasswordBox";
            this.managerPasswordBox.Size = new System.Drawing.Size(143, 21);
            this.managerPasswordBox.TabIndex = 3;
            // 
            // managerPasswordlabel
            // 
            this.managerPasswordlabel.AutoSize = true;
            this.managerPasswordlabel.Location = new System.Drawing.Point(22, 68);
            this.managerPasswordlabel.Name = "managerPasswordlabel";
            this.managerPasswordlabel.Size = new System.Drawing.Size(77, 12);
            this.managerPasswordlabel.TabIndex = 2;
            this.managerPasswordlabel.Text = "管理员密码：";
            // 
            // enterPasswordBox
            // 
            this.enterPasswordBox.Location = new System.Drawing.Point(104, 152);
            this.enterPasswordBox.Name = "enterPasswordBox";
            this.enterPasswordBox.Size = new System.Drawing.Size(143, 21);
            this.enterPasswordBox.TabIndex = 5;
            // 
            // enterPasswordlabel
            // 
            this.enterPasswordlabel.AutoSize = true;
            this.enterPasswordlabel.Location = new System.Drawing.Point(28, 155);
            this.enterPasswordlabel.Name = "enterPasswordlabel";
            this.enterPasswordlabel.Size = new System.Drawing.Size(65, 12);
            this.enterPasswordlabel.TabIndex = 4;
            this.enterPasswordlabel.Text = "参与密码：";
            // 
            // listeningPasswordBox
            // 
            this.listeningPasswordBox.Location = new System.Drawing.Point(104, 199);
            this.listeningPasswordBox.Name = "listeningPasswordBox";
            this.listeningPasswordBox.Size = new System.Drawing.Size(143, 21);
            this.listeningPasswordBox.TabIndex = 7;
            // 
            // listeningPasswordlabel
            // 
            this.listeningPasswordlabel.AutoSize = true;
            this.listeningPasswordlabel.Location = new System.Drawing.Point(22, 202);
            this.listeningPasswordlabel.Name = "listeningPasswordlabel";
            this.listeningPasswordlabel.Size = new System.Drawing.Size(65, 12);
            this.listeningPasswordlabel.TabIndex = 6;
            this.listeningPasswordlabel.Text = "旁听密码：";
            // 
            // comperePasswordBox
            // 
            this.comperePasswordBox.Location = new System.Drawing.Point(104, 112);
            this.comperePasswordBox.Name = "comperePasswordBox";
            this.comperePasswordBox.Size = new System.Drawing.Size(143, 21);
            this.comperePasswordBox.TabIndex = 9;
            // 
            // comperePasswordlabel
            // 
            this.comperePasswordlabel.AutoSize = true;
            this.comperePasswordlabel.Location = new System.Drawing.Point(16, 112);
            this.comperePasswordlabel.Name = "comperePasswordlabel";
            this.comperePasswordlabel.Size = new System.Drawing.Size(77, 12);
            this.comperePasswordlabel.TabIndex = 8;
            this.comperePasswordlabel.Text = "主持人密码：";
            // 
            // maxPersonOfNumbertextBox
            // 
            this.maxPersonOfNumbertextBox.Location = new System.Drawing.Point(104, 272);
            this.maxPersonOfNumbertextBox.Name = "maxPersonOfNumbertextBox";
            this.maxPersonOfNumbertextBox.Size = new System.Drawing.Size(143, 21);
            this.maxPersonOfNumbertextBox.TabIndex = 11;
            // 
            // maxPersonOfNumberlabel
            // 
            this.maxPersonOfNumberlabel.AutoSize = true;
            this.maxPersonOfNumberlabel.Location = new System.Drawing.Point(22, 275);
            this.maxPersonOfNumberlabel.Name = "maxPersonOfNumberlabel";
            this.maxPersonOfNumberlabel.Size = new System.Drawing.Size(65, 12);
            this.maxPersonOfNumberlabel.TabIndex = 10;
            this.maxPersonOfNumberlabel.Text = "最大人数：";
            // 
            // roomInfoSubmit
            // 
            this.roomInfoSubmit.Location = new System.Drawing.Point(42, 322);
            this.roomInfoSubmit.Name = "roomInfoSubmit";
            this.roomInfoSubmit.Size = new System.Drawing.Size(75, 23);
            this.roomInfoSubmit.TabIndex = 12;
            this.roomInfoSubmit.Text = "roomInfoSubmit";
            this.roomInfoSubmit.UseVisualStyleBackColor = true;
            this.roomInfoSubmit.Click += new System.EventHandler(this.roomInfoSubmit_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(141, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PassWordDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.roomInfoSubmit);
            this.Controls.Add(this.maxPersonOfNumbertextBox);
            this.Controls.Add(this.maxPersonOfNumberlabel);
            this.Controls.Add(this.comperePasswordBox);
            this.Controls.Add(this.comperePasswordlabel);
            this.Controls.Add(this.listeningPasswordBox);
            this.Controls.Add(this.listeningPasswordlabel);
            this.Controls.Add(this.enterPasswordBox);
            this.Controls.Add(this.enterPasswordlabel);
            this.Controls.Add(this.managerPasswordBox);
            this.Controls.Add(this.managerPasswordlabel);
            this.Controls.Add(this.roomNameText);
            this.Controls.Add(this.roomNameLabel);
            this.Name = "PassWordDialogBox";
            this.Size = new System.Drawing.Size(283, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomNameText;
        private System.Windows.Forms.TextBox managerPasswordBox;
        private System.Windows.Forms.Label managerPasswordlabel;
        private System.Windows.Forms.TextBox enterPasswordBox;
        private System.Windows.Forms.Label enterPasswordlabel;
        private System.Windows.Forms.TextBox listeningPasswordBox;
        private System.Windows.Forms.Label listeningPasswordlabel;
        private System.Windows.Forms.TextBox comperePasswordBox;
        private System.Windows.Forms.Label comperePasswordlabel;
        private System.Windows.Forms.TextBox maxPersonOfNumbertextBox;
        private System.Windows.Forms.Label maxPersonOfNumberlabel;
        private System.Windows.Forms.Button roomInfoSubmit;
        private System.Windows.Forms.Button cancelButton;
    }
}
