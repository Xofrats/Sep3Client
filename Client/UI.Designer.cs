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
			this.btnAddFriend = new System.Windows.Forms.Button();
			this.btnDeleteFriend = new System.Windows.Forms.Button();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFriendRequest = new System.Windows.Forms.TextBox();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnReject = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAllRequest = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnSendMessage
			// 
			this.BtnSendMessage.Location = new System.Drawing.Point(328, 294);
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
			this.TextBoxMessage.Location = new System.Drawing.Point(28, 295);
			this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(2);
			this.TextBoxMessage.Multiline = true;
			this.TextBoxMessage.Name = "TextBoxMessage";
			this.TextBoxMessage.Size = new System.Drawing.Size(296, 43);
			this.TextBoxMessage.TabIndex = 1;
			// 
			// TbChatWindow
			// 
			this.TbChatWindow.Location = new System.Drawing.Point(28, 43);
			this.TbChatWindow.Margin = new System.Windows.Forms.Padding(2);
			this.TbChatWindow.Multiline = true;
			this.TbChatWindow.Name = "TbChatWindow";
			this.TbChatWindow.ReadOnly = true;
			this.TbChatWindow.Size = new System.Drawing.Size(356, 247);
			this.TbChatWindow.TabIndex = 2;
			// 
			// TbFriends
			// 
			this.TbFriends.Location = new System.Drawing.Point(446, 43);
			this.TbFriends.Margin = new System.Windows.Forms.Padding(2);
			this.TbFriends.Multiline = true;
			this.TbFriends.Name = "TbFriends";
			this.TbFriends.ReadOnly = true;
			this.TbFriends.Size = new System.Drawing.Size(147, 247);
			this.TbFriends.TabIndex = 3;
			// 
			// BtnFriends
			// 
			this.BtnFriends.Location = new System.Drawing.Point(447, 295);
			this.BtnFriends.Name = "BtnFriends";
			this.BtnFriends.Size = new System.Drawing.Size(146, 23);
			this.BtnFriends.TabIndex = 4;
			this.BtnFriends.Text = "Show Friends";
			this.BtnFriends.UseVisualStyleBackColor = true;
			this.BtnFriends.Click += new System.EventHandler(this.GetFriends);
			// 
			// btnAddFriend
			// 
			this.btnAddFriend.Location = new System.Drawing.Point(446, 377);
			this.btnAddFriend.Name = "btnAddFriend";
			this.btnAddFriend.Size = new System.Drawing.Size(65, 23);
			this.btnAddFriend.TabIndex = 5;
			this.btnAddFriend.Text = "Add";
			this.btnAddFriend.UseVisualStyleBackColor = true;
			this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
			// 
			// btnDeleteFriend
			// 
			this.btnDeleteFriend.Location = new System.Drawing.Point(518, 377);
			this.btnDeleteFriend.Name = "btnDeleteFriend";
			this.btnDeleteFriend.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFriend.TabIndex = 6;
			this.btnDeleteFriend.Text = "Delete";
			this.btnDeleteFriend.UseVisualStyleBackColor = true;
			this.btnDeleteFriend.Click += new System.EventHandler(this.btnDeleteFriend_Click);
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(446, 351);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(146, 20);
			this.textBoxUsername.TabIndex = 7;
			this.textBoxUsername.Text = "Username";
			this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(467, 335);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Add or Delete friends";
			// 
			// textBoxFriendRequest
			// 
			this.textBoxFriendRequest.Location = new System.Drawing.Point(446, 445);
			this.textBoxFriendRequest.Name = "textBoxFriendRequest";
			this.textBoxFriendRequest.Size = new System.Drawing.Size(147, 20);
			this.textBoxFriendRequest.TabIndex = 9;
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(446, 471);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(65, 23);
			this.btnAccept.TabIndex = 10;
			this.btnAccept.Text = "Accept";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnReject
			// 
			this.btnReject.Location = new System.Drawing.Point(518, 471);
			this.btnReject.Name = "btnReject";
			this.btnReject.Size = new System.Drawing.Size(75, 23);
			this.btnReject.TabIndex = 11;
			this.btnReject.Text = "Reject";
			this.btnReject.UseVisualStyleBackColor = true;
			this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(467, 429);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Friend request from:";
			// 
			// textBoxAllRequest
			// 
			this.textBoxAllRequest.Location = new System.Drawing.Point(328, 405);
			this.textBoxAllRequest.Multiline = true;
			this.textBoxAllRequest.Name = "textBoxAllRequest";
			this.textBoxAllRequest.Size = new System.Drawing.Size(100, 89);
			this.textBoxAllRequest.TabIndex = 13;
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 523);
			this.Controls.Add(this.textBoxAllRequest);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnReject);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.textBoxFriendRequest);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.btnDeleteFriend);
			this.Controls.Add(this.btnAddFriend);
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
    private System.Windows.Forms.Button btnAddFriend;
    private System.Windows.Forms.Button btnDeleteFriend;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxFriendRequest;
    private System.Windows.Forms.Button btnAccept;
    private System.Windows.Forms.Button btnReject;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxAllRequest;
  }
}
