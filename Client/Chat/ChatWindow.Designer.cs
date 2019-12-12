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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbMessage
            // 
            this.TbMessage.Location = new System.Drawing.Point(12, 416);
            this.TbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbMessage.Multiline = true;
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(643, 51);
            this.TbMessage.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(661, 416);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(127, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.SendChat);
            // 
            // TbChatWindow
            // 
            this.TbChatWindow.Location = new System.Drawing.Point(12, 42);
            this.TbChatWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbChatWindow.Multiline = true;
            this.TbChatWindow.Name = "TbChatWindow";
            this.TbChatWindow.Size = new System.Drawing.Size(760, 368);
            this.TbChatWindow.TabIndex = 2;
            // 
            // TbChatTitle
            // 
            this.TbChatTitle.Location = new System.Drawing.Point(285, 12);
            this.TbChatTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbChatTitle.Name = "TbChatTitle";
            this.TbChatTitle.Size = new System.Drawing.Size(247, 22);
            this.TbChatTitle.TabIndex = 3;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(661, 444);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(127, 23);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.Text = "Send file";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTNVoiceChat_Start);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.TbChatTitle);
            this.Controls.Add(this.TbChatWindow);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
		private System.Windows.Forms.Button button1;
	}
}
