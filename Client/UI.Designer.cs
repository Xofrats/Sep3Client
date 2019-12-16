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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TbFriends
			// 
			this.TbFriends.Location = new System.Drawing.Point(11, 25);
			this.TbFriends.Margin = new System.Windows.Forms.Padding(2);
			this.TbFriends.Multiline = true;
			this.TbFriends.Name = "TbFriends";
			this.TbFriends.ReadOnly = true;
			this.TbFriends.Size = new System.Drawing.Size(147, 247);
			this.TbFriends.TabIndex = 3;
			// 
			// BtnFriends
			// 
			this.BtnFriends.Location = new System.Drawing.Point(11, 277);
			this.BtnFriends.Name = "BtnFriends";
			this.BtnFriends.Size = new System.Drawing.Size(65, 23);
			this.BtnFriends.TabIndex = 4;
			this.BtnFriends.Text = "Friends";
			this.BtnFriends.UseVisualStyleBackColor = true;
			this.BtnFriends.Click += new System.EventHandler(this.GetFriends);
			// 
			// btnAddFriend
			// 
			this.btnAddFriend.Location = new System.Drawing.Point(11, 366);
			this.btnAddFriend.Name = "btnAddFriend";
			this.btnAddFriend.Size = new System.Drawing.Size(65, 23);
			this.btnAddFriend.TabIndex = 5;
			this.btnAddFriend.Text = "Add";
			this.btnAddFriend.UseVisualStyleBackColor = true;
			this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
			// 
			// btnDeleteFriend
			// 
			this.btnDeleteFriend.Location = new System.Drawing.Point(83, 366);
			this.btnDeleteFriend.Name = "btnDeleteFriend";
			this.btnDeleteFriend.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFriend.TabIndex = 6;
			this.btnDeleteFriend.Text = "Delete";
			this.btnDeleteFriend.UseVisualStyleBackColor = true;
			this.btnDeleteFriend.Click += new System.EventHandler(this.BtnDeleteFriend_Click);
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(11, 340);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(146, 20);
			this.textBoxUsername.TabIndex = 7;
			this.textBoxUsername.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 324);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Add or Delete friends";
			// 
			// textBoxFriendRequest
			// 
			this.textBoxFriendRequest.Location = new System.Drawing.Point(142, 448);
			this.textBoxFriendRequest.Name = "textBoxFriendRequest";
			this.textBoxFriendRequest.ReadOnly = true;
			this.textBoxFriendRequest.Size = new System.Drawing.Size(147, 20);
			this.textBoxFriendRequest.TabIndex = 9;
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(142, 474);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(65, 23);
			this.btnAccept.TabIndex = 10;
			this.btnAccept.Text = "Accept";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
			// 
			// btnReject
			// 
			this.btnReject.Location = new System.Drawing.Point(214, 474);
			this.btnReject.Name = "btnReject";
			this.btnReject.Size = new System.Drawing.Size(75, 23);
			this.btnReject.TabIndex = 11;
			this.btnReject.Text = "Reject";
			this.btnReject.UseVisualStyleBackColor = true;
			this.btnReject.Click += new System.EventHandler(this.BtnReject_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(165, 427);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Friend request from:";
			// 
			// textBoxAllRequest
			// 
			this.textBoxAllRequest.Location = new System.Drawing.Point(11, 427);
			this.textBoxAllRequest.Multiline = true;
			this.textBoxAllRequest.Name = "textBoxAllRequest";
			this.textBoxAllRequest.ReadOnly = true;
			this.textBoxAllRequest.Size = new System.Drawing.Size(125, 88);
			this.textBoxAllRequest.TabIndex = 13;
			// 
			// btnGetFriendRequest
			// 
			this.btnGetFriendRequest.Location = new System.Drawing.Point(11, 521);
			this.btnGetFriendRequest.Name = "btnGetFriendRequest";
			this.btnGetFriendRequest.Size = new System.Drawing.Size(125, 23);
			this.btnGetFriendRequest.TabIndex = 14;
			this.btnGetFriendRequest.Text = "Get Friend Request";
			this.btnGetFriendRequest.UseVisualStyleBackColor = true;
			this.btnGetFriendRequest.Click += new System.EventHandler(this.btnGetFriendRequest_Click);
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Location = new System.Drawing.Point(142, 524);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ReadOnly = true;
			this.textBoxStatus.Size = new System.Drawing.Size(146, 20);
			this.textBoxStatus.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 508);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Status";
			// 
			// HiddenFriends
			// 
			this.HiddenFriends.Location = new System.Drawing.Point(12, 10);
			this.HiddenFriends.Name = "HiddenFriends";
			this.HiddenFriends.Size = new System.Drawing.Size(10, 10);
			this.HiddenFriends.TabIndex = 17;
			this.HiddenFriends.UseVisualStyleBackColor = true;
			this.HiddenFriends.Click += new System.EventHandler(this.BTNHiddenFriends_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(167, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Opret gruppe chat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.bntOpretGruppe);
			// 
			// btnGroups
			// 
			this.btnGroups.Location = new System.Drawing.Point(83, 278);
			this.btnGroups.Name = "btnGroups";
			this.btnGroups.Size = new System.Drawing.Size(73, 23);
			this.btnGroups.TabIndex = 19;
			this.btnGroups.Text = "Groups";
			this.btnGroups.UseVisualStyleBackColor = true;
			this.btnGroups.Click += new System.EventHandler(this.GetGroups);
			// 
			// HiddenGroups
			// 
			this.HiddenGroups.Location = new System.Drawing.Point(28, 10);
			this.HiddenGroups.Name = "HiddenGroups";
			this.HiddenGroups.Size = new System.Drawing.Size(10, 10);
			this.HiddenGroups.TabIndex = 20;
			this.HiddenGroups.Text = "button2";
			this.HiddenGroups.UseVisualStyleBackColor = true;
			this.HiddenGroups.Click += new System.EventHandler(this.btnGroupChat_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(168, 340);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(127, 20);
			this.textBox1.TabIndex = 21;
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 565);
			this.Controls.Add(this.textBox1);
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
			this.Margin = new System.Windows.Forms.Padding(2);
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
    private System.Windows.Forms.TextBox tbCreateGroup;
    private System.Windows.Forms.TextBox textBox1;
  }
}
