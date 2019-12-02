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
            this.TBloginuser = new System.Windows.Forms.TextBox();
            this.TBloginPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Location = new System.Drawing.Point(437, 362);
            this.BtnSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.BtnSendMessage.TabIndex = 0;
            this.BtnSendMessage.Text = "Send";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.WriteToServer);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(37, 363);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(393, 52);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // TbChatWindow
            // 
            this.TbChatWindow.Location = new System.Drawing.Point(37, 53);
            this.TbChatWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbChatWindow.Multiline = true;
            this.TbChatWindow.Name = "TbChatWindow";
            this.TbChatWindow.ReadOnly = true;
            this.TbChatWindow.Size = new System.Drawing.Size(473, 303);
            this.TbChatWindow.TabIndex = 2;
            // 
            // TbFriends
            // 
            this.TbFriends.Location = new System.Drawing.Point(595, 53);
            this.TbFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbFriends.Multiline = true;
            this.TbFriends.Name = "TbFriends";
            this.TbFriends.ReadOnly = true;
            this.TbFriends.Size = new System.Drawing.Size(195, 303);
            this.TbFriends.TabIndex = 3;
            // 
            // BtnFriends
            // 
            this.BtnFriends.Location = new System.Drawing.Point(596, 363);
            this.BtnFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFriends.Name = "BtnFriends";
            this.BtnFriends.Size = new System.Drawing.Size(195, 28);
            this.BtnFriends.TabIndex = 4;
            this.BtnFriends.Text = "Show Friends";
            this.BtnFriends.UseVisualStyleBackColor = true;
            this.BtnFriends.Click += new System.EventHandler(this.GetFriends);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(595, 464);
            this.btnAddFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(87, 28);
            this.btnAddFriend.TabIndex = 5;
            this.btnAddFriend.Text = "Add";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // btnDeleteFriend
            // 
            this.btnDeleteFriend.Location = new System.Drawing.Point(691, 464);
            this.btnDeleteFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteFriend.Name = "btnDeleteFriend";
            this.btnDeleteFriend.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteFriend.TabIndex = 6;
            this.btnDeleteFriend.Text = "Delete";
            this.btnDeleteFriend.UseVisualStyleBackColor = true;
            this.btnDeleteFriend.Click += new System.EventHandler(this.btnDeleteFriend_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(595, 432);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(193, 22);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add or Delete friends";
            // 
            // textBoxFriendRequest
            // 
            this.textBoxFriendRequest.Location = new System.Drawing.Point(595, 548);
            this.textBoxFriendRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFriendRequest.Name = "textBoxFriendRequest";
            this.textBoxFriendRequest.Size = new System.Drawing.Size(195, 22);
            this.textBoxFriendRequest.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(595, 580);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(87, 28);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(691, 580);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 28);
            this.btnReject.TabIndex = 11;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Friend request from:";
            // 
            // TBloginuser
            // 
            this.TBloginuser.Location = new System.Drawing.Point(37, 454);
            this.TBloginuser.Name = "TBloginuser";
            this.TBloginuser.Size = new System.Drawing.Size(100, 22);
            this.TBloginuser.TabIndex = 13;
            // 
            // TBloginPass
            // 
            this.TBloginPass.Location = new System.Drawing.Point(37, 483);
            this.TBloginPass.Name = "TBloginPass";
            this.TBloginPass.Size = new System.Drawing.Size(100, 22);
            this.TBloginPass.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "password";
            // 
            // BTNlogin
            // 
            this.BTNlogin.Location = new System.Drawing.Point(103, 525);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(75, 23);
            this.BTNlogin.TabIndex = 17;
            this.BTNlogin.Text = "login";
            this.BTNlogin.UseVisualStyleBackColor = true;
            this.BTNlogin.Click += new System.EventHandler(this.btnLogin);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 644);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBloginPass);
            this.Controls.Add(this.TBloginuser);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox TBloginuser;
        private System.Windows.Forms.TextBox TBloginPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNlogin;
    }
}
