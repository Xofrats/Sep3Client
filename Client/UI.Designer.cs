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
            this.TbFriends = new System.Windows.Forms.TextBox();
            this.BtnFriends = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.btnDeleteFriend = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFriendRequest = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAllRequest = new System.Windows.Forms.TextBox();
            this.btnGetFriendRequest = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HiddenFriends = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.HiddenGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbFriends
            // 
            this.TbFriends.Location = new System.Drawing.Point(15, 31);
            this.TbFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbFriends.Multiline = true;
            this.TbFriends.Name = "TbFriends";
            this.TbFriends.ReadOnly = true;
            this.TbFriends.Size = new System.Drawing.Size(195, 303);
            this.TbFriends.TabIndex = 3;
            // 
            // BtnFriends
            // 
            this.BtnFriends.Location = new System.Drawing.Point(15, 341);
            this.BtnFriends.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFriends.Name = "BtnFriends";
            this.BtnFriends.Size = new System.Drawing.Size(87, 28);
            this.BtnFriends.TabIndex = 4;
            this.BtnFriends.Text = "Friends";
            this.BtnFriends.UseVisualStyleBackColor = true;
            this.BtnFriends.Click += new System.EventHandler(this.GetFriends);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(15, 450);
            this.btnAddFriend.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(87, 28);
            this.btnAddFriend.TabIndex = 5;
            this.btnAddFriend.Text = "Add";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFriend
            // 
            this.btnDeleteFriend.Location = new System.Drawing.Point(111, 450);
            this.btnDeleteFriend.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFriend.Name = "btnDeleteFriend";
            this.btnDeleteFriend.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteFriend.TabIndex = 6;
            this.btnDeleteFriend.Text = "Delete";
            this.btnDeleteFriend.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(15, 418);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(193, 22);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add or Delete friends";
            // 
            // textBoxFriendRequest
            // 
            this.textBoxFriendRequest.Location = new System.Drawing.Point(189, 551);
            this.textBoxFriendRequest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFriendRequest.Name = "textBoxFriendRequest";
            this.textBoxFriendRequest.ReadOnly = true;
            this.textBoxFriendRequest.Size = new System.Drawing.Size(195, 22);
            this.textBoxFriendRequest.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(189, 583);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(87, 28);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(285, 583);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 28);
            this.btnReject.TabIndex = 11;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Friend request from:";
            // 
            // textBoxAllRequest
            // 
            this.textBoxAllRequest.Location = new System.Drawing.Point(15, 526);
            this.textBoxAllRequest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAllRequest.Multiline = true;
            this.textBoxAllRequest.Name = "textBoxAllRequest";
            this.textBoxAllRequest.ReadOnly = true;
            this.textBoxAllRequest.Size = new System.Drawing.Size(165, 107);
            this.textBoxAllRequest.TabIndex = 13;
            // 
            // btnGetFriendRequest
            // 
            this.btnGetFriendRequest.Location = new System.Drawing.Point(15, 641);
            this.btnGetFriendRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFriendRequest.Name = "btnGetFriendRequest";
            this.btnGetFriendRequest.Size = new System.Drawing.Size(167, 28);
            this.btnGetFriendRequest.TabIndex = 14;
            this.btnGetFriendRequest.Text = "Get Friend Request";
            this.btnGetFriendRequest.UseVisualStyleBackColor = true;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(189, 645);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(193, 22);
            this.textBoxStatus.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 625);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status";
            // 
            // HiddenFriends
            // 
            this.HiddenFriends.Location = new System.Drawing.Point(16, 12);
            this.HiddenFriends.Margin = new System.Windows.Forms.Padding(4);
            this.HiddenFriends.Name = "HiddenFriends";
            this.HiddenFriends.Size = new System.Drawing.Size(13, 12);
            this.HiddenFriends.TabIndex = 17;
            this.HiddenFriends.UseVisualStyleBackColor = true;
            this.HiddenFriends.Click += new System.EventHandler(this.BTNHiddenFriends_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Opret gruppe chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bntOpretGruppe);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(111, 342);
            this.btnGroups.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(97, 28);
            this.btnGroups.TabIndex = 19;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.GetGroups);
            // 
            // HiddenGroups
            // 
            this.HiddenGroups.Location = new System.Drawing.Point(37, 12);
            this.HiddenGroups.Margin = new System.Windows.Forms.Padding(4);
            this.HiddenGroups.Name = "HiddenGroups";
            this.HiddenGroups.Size = new System.Drawing.Size(13, 12);
            this.HiddenGroups.TabIndex = 20;
            this.HiddenGroups.Text = "button2";
            this.HiddenGroups.UseVisualStyleBackColor = true;
            this.HiddenGroups.Click += new System.EventHandler(this.btnGroupChat_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 695);
            this.Controls.Add(this.HiddenGroups);
            this.Controls.Add(this.btnGroups);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HiddenFriends);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.btnGetFriendRequest);
            this.Controls.Add(this.textBoxAllRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.textBoxFriendRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.btnDeleteFriend);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.BtnFriends);
            this.Controls.Add(this.TbFriends);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbFriends;
        private System.Windows.Forms.Button BtnFriends;
    private System.Windows.Forms.Button btnAddFriend;
    private System.Windows.Forms.Button btnDeleteFriend;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxFriendRequest;
    private System.Windows.Forms.Button btnAccept;
    private System.Windows.Forms.Button btnReject;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxAllRequest;
    private System.Windows.Forms.Button btnGetFriendRequest;
    private System.Windows.Forms.TextBox textBoxStatus;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button HiddenFriends;
        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnGroups;
    private System.Windows.Forms.Button HiddenGroups;
    }
}
