namespace Client
{
    partial class UI
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
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.TbChatWindow = new System.Windows.Forms.TextBox();
            this.TbFriends = new System.Windows.Forms.TextBox();
            this.BtnFriends = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Location = new System.Drawing.Point(526, 327);
            this.BtnSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(56, 19);
            this.BtnSendMessage.TabIndex = 0;
            this.BtnSendMessage.Text = "Send";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.WriteToServer);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(28, 327);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(485, 20);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // TbChatWindow
            // 
            this.TbChatWindow.Location = new System.Drawing.Point(28, 43);
            this.TbChatWindow.Margin = new System.Windows.Forms.Padding(2);
            this.TbChatWindow.Multiline = true;
            this.TbChatWindow.Name = "TbChatWindow";
            this.TbChatWindow.Size = new System.Drawing.Size(356, 279);
            this.TbChatWindow.TabIndex = 2;
            // 
            // TbFriends
            // 
            this.TbFriends.Location = new System.Drawing.Point(436, 43);
            this.TbFriends.Margin = new System.Windows.Forms.Padding(2);
            this.TbFriends.Multiline = true;
            this.TbFriends.Name = "TbFriends";
            this.TbFriends.Size = new System.Drawing.Size(147, 247);
            this.TbFriends.TabIndex = 3;
            // 
            // BtnFriends
            // 
            this.BtnFriends.Location = new System.Drawing.Point(436, 295);
            this.BtnFriends.Name = "BtnFriends";
            this.BtnFriends.Size = new System.Drawing.Size(146, 23);
            this.BtnFriends.TabIndex = 4;
            this.BtnFriends.Text = "Show Friends";
            this.BtnFriends.UseVisualStyleBackColor = true;
            this.BtnFriends.Click += new System.EventHandler(this.GetFriends);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnFriends);
            this.Controls.Add(this.TbFriends);
            this.Controls.Add(this.TbChatWindow);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.BtnSendMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendMessage;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.TextBox TbChatWindow;
        private System.Windows.Forms.TextBox TbFriends;
        private System.Windows.Forms.Button BtnFriends;
    }
}