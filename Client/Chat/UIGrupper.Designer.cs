namespace Client
{
    partial class UIGrupper
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
			this.tbMessage = new System.Windows.Forms.TextBox();
			this.bntSendChat = new System.Windows.Forms.Button();
			this.bntTilføj = new System.Windows.Forms.Button();
			this.tbMember = new System.Windows.Forms.TextBox();
			this.bntFjern = new System.Windows.Forms.Button();
			this.tbChat = new System.Windows.Forms.TextBox();
			this.tbGroupMembers = new System.Windows.Forms.TextBox();
			this.btnGetMembers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbMessage
			// 
			this.tbMessage.Location = new System.Drawing.Point(22, 329);
			this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
			this.tbMessage.Multiline = true;
			this.tbMessage.Name = "tbMessage";
			this.tbMessage.Size = new System.Drawing.Size(320, 47);
			this.tbMessage.TabIndex = 1;
			// 
			// bntSendChat
			// 
			this.bntSendChat.Location = new System.Drawing.Point(22, 380);
			this.bntSendChat.Margin = new System.Windows.Forms.Padding(2);
			this.bntSendChat.Name = "bntSendChat";
			this.bntSendChat.Size = new System.Drawing.Size(76, 21);
			this.bntSendChat.TabIndex = 2;
			this.bntSendChat.Text = "Send";
			this.bntSendChat.UseVisualStyleBackColor = true;
			this.bntSendChat.Click += new System.EventHandler(this.bntSendChat_Click);
			// 
			// bntTilføj
			// 
			this.bntTilføj.Location = new System.Drawing.Point(22, 450);
			this.bntTilføj.Margin = new System.Windows.Forms.Padding(2);
			this.bntTilføj.Name = "bntTilføj";
			this.bntTilføj.Size = new System.Drawing.Size(95, 23);
			this.bntTilføj.TabIndex = 6;
			this.bntTilføj.Text = "Add member";
			this.bntTilføj.UseVisualStyleBackColor = true;
			this.bntTilføj.Click += new System.EventHandler(this.BntTilføj_Click);
			// 
			// tbMember
			// 
			this.tbMember.Location = new System.Drawing.Point(22, 426);
			this.tbMember.Margin = new System.Windows.Forms.Padding(2);
			this.tbMember.Name = "tbMember";
			this.tbMember.Size = new System.Drawing.Size(195, 20);
			this.tbMember.TabIndex = 7;
			// 
			// bntFjern
			// 
			this.bntFjern.Location = new System.Drawing.Point(121, 450);
			this.bntFjern.Margin = new System.Windows.Forms.Padding(2);
			this.bntFjern.Name = "bntFjern";
			this.bntFjern.Size = new System.Drawing.Size(96, 22);
			this.bntFjern.TabIndex = 8;
			this.bntFjern.Text = "Remove member";
			this.bntFjern.UseVisualStyleBackColor = true;
			this.bntFjern.Click += new System.EventHandler(this.bntFjern_Click);
			// 
			// tbChat
			// 
			this.tbChat.Location = new System.Drawing.Point(22, 18);
			this.tbChat.Margin = new System.Windows.Forms.Padding(2);
			this.tbChat.Multiline = true;
			this.tbChat.Name = "tbChat";
			this.tbChat.ReadOnly = true;
			this.tbChat.Size = new System.Drawing.Size(320, 298);
			this.tbChat.TabIndex = 9;
			// 
			// tbGroupMembers
			// 
			this.tbGroupMembers.Location = new System.Drawing.Point(363, 18);
			this.tbGroupMembers.Multiline = true;
			this.tbGroupMembers.Name = "tbGroupMembers";
			this.tbGroupMembers.ReadOnly = true;
			this.tbGroupMembers.Size = new System.Drawing.Size(148, 297);
			this.tbGroupMembers.TabIndex = 10;
			// 
			// btnGetMembers
			// 
			this.btnGetMembers.Location = new System.Drawing.Point(363, 327);
			this.btnGetMembers.Name = "btnGetMembers";
			this.btnGetMembers.Size = new System.Drawing.Size(144, 23);
			this.btnGetMembers.TabIndex = 11;
			this.btnGetMembers.Text = "View group members";
			this.btnGetMembers.UseVisualStyleBackColor = true;
			this.btnGetMembers.Click += new System.EventHandler(this.btnGetMembers_Click);
			// 
			// UIGrupper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 501);
			this.Controls.Add(this.btnGetMembers);
			this.Controls.Add(this.tbGroupMembers);
			this.Controls.Add(this.tbChat);
			this.Controls.Add(this.bntFjern);
			this.Controls.Add(this.tbMember);
			this.Controls.Add(this.bntTilføj);
			this.Controls.Add(this.bntSendChat);
			this.Controls.Add(this.tbMessage);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UIGrupper";
			this.Text = "Grupper";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bntSendChat;
        private System.Windows.Forms.Button bntTilføj;
        private System.Windows.Forms.TextBox tbMember;
        private System.Windows.Forms.Button bntFjern;
		private System.Windows.Forms.TextBox tbChat;
    private System.Windows.Forms.TextBox tbGroupMembers;
    private System.Windows.Forms.Button btnGetMembers;
  }
}