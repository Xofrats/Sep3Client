namespace Client
{
    partial class ChatWindow
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
			this.TbMessage = new System.Windows.Forms.TextBox();
			this.BtnSend = new System.Windows.Forms.Button();
			this.TbChatWindow = new System.Windows.Forms.TextBox();
			this.TbChatTitle = new System.Windows.Forms.TextBox();
			this.btnSendFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TbMessage
			// 
			this.TbMessage.Location = new System.Drawing.Point(9, 338);
			this.TbMessage.Margin = new System.Windows.Forms.Padding(2);
			this.TbMessage.Multiline = true;
			this.TbMessage.Name = "TbMessage";
			this.TbMessage.Size = new System.Drawing.Size(483, 42);
			this.TbMessage.TabIndex = 0;
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(496, 338);
			this.BtnSend.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(95, 19);
			this.BtnSend.TabIndex = 1;
			this.BtnSend.Text = "Send";
			this.BtnSend.UseVisualStyleBackColor = true;
			this.BtnSend.Click += new System.EventHandler(this.SendChat);
			// 
			// TbChatWindow
			// 
			this.TbChatWindow.Location = new System.Drawing.Point(9, 34);
			this.TbChatWindow.Margin = new System.Windows.Forms.Padding(2);
			this.TbChatWindow.Multiline = true;
			this.TbChatWindow.Name = "TbChatWindow";
			this.TbChatWindow.Size = new System.Drawing.Size(571, 300);
			this.TbChatWindow.TabIndex = 2;
			// 
			// TbChatTitle
			// 
			this.TbChatTitle.Location = new System.Drawing.Point(214, 10);
			this.TbChatTitle.Margin = new System.Windows.Forms.Padding(2);
			this.TbChatTitle.Name = "TbChatTitle";
			this.TbChatTitle.Size = new System.Drawing.Size(186, 20);
			this.TbChatTitle.TabIndex = 3;
			// 
			// btnSendFile
			// 
			this.btnSendFile.Location = new System.Drawing.Point(496, 361);
			this.btnSendFile.Margin = new System.Windows.Forms.Padding(2);
			this.btnSendFile.Name = "btnSendFile";
			this.btnSendFile.Size = new System.Drawing.Size(95, 19);
			this.btnSendFile.TabIndex = 4;
			this.btnSendFile.Text = "Send file";
			this.btnSendFile.UseVisualStyleBackColor = true;
			this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
			// 
			// ChatWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 402);
			this.Controls.Add(this.btnSendFile);
			this.Controls.Add(this.TbChatTitle);
			this.Controls.Add(this.TbChatWindow);
			this.Controls.Add(this.BtnSend);
			this.Controls.Add(this.TbMessage);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ChatWindow";
			this.Text = "ChatWindow";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TbChatWindow;
        private System.Windows.Forms.TextBox TbChatTitle;
    private System.Windows.Forms.Button btnSendFile;
  }
}
