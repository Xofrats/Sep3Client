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
			this.tbMembers = new System.Windows.Forms.RichTextBox();
			this.bntTilføj = new System.Windows.Forms.Button();
			this.tbMember = new System.Windows.Forms.TextBox();
			this.bntFjern = new System.Windows.Forms.Button();
			this.tbChat = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbMessage
			// 
			this.tbMessage.Location = new System.Drawing.Point(22, 329);
			this.tbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbMessage.Multiline = true;
			this.tbMessage.Name = "tbMessage";
			this.tbMessage.Size = new System.Drawing.Size(320, 47);
			this.tbMessage.TabIndex = 1;
			// 
			// bntSendChat
			// 
			this.bntSendChat.Location = new System.Drawing.Point(150, 380);
			this.bntSendChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bntSendChat.Name = "bntSendChat";
			this.bntSendChat.Size = new System.Drawing.Size(66, 28);
			this.bntSendChat.TabIndex = 2;
			this.bntSendChat.Text = "Send";
			this.bntSendChat.UseVisualStyleBackColor = true;
			this.bntSendChat.Click += new System.EventHandler(this.bntSendChat_Click);
			// 
			// tbMembers
			// 
			this.tbMembers.Location = new System.Drawing.Point(363, 18);
			this.tbMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbMembers.Name = "tbMembers";
			this.tbMembers.ReadOnly = true;
			this.tbMembers.Size = new System.Drawing.Size(148, 298);
			this.tbMembers.TabIndex = 3;
			this.tbMembers.Text = "";
			// 
			// bntTilføj
			// 
			this.bntTilføj.Location = new System.Drawing.Point(363, 353);
			this.bntTilføj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bntTilføj.Name = "bntTilføj";
			this.bntTilføj.Size = new System.Drawing.Size(64, 23);
			this.bntTilføj.TabIndex = 6;
			this.bntTilføj.Text = "Tilføj";
			this.bntTilføj.UseVisualStyleBackColor = true;
			this.bntTilføj.Click += new System.EventHandler(this.BntTilføj_Click);
			// 
			// tbMember
			// 
			this.tbMember.Location = new System.Drawing.Point(363, 329);
			this.tbMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbMember.Name = "tbMember";
			this.tbMember.Size = new System.Drawing.Size(148, 20);
			this.tbMember.TabIndex = 7;
			// 
			// bntFjern
			// 
			this.bntFjern.Location = new System.Drawing.Point(446, 353);
			this.bntFjern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bntFjern.Name = "bntFjern";
			this.bntFjern.Size = new System.Drawing.Size(65, 22);
			this.bntFjern.TabIndex = 8;
			this.bntFjern.Text = "Fjern";
			this.bntFjern.UseVisualStyleBackColor = true;
			this.bntFjern.Click += new System.EventHandler(this.bntFjern_Click);
			// 
			// tbChat
			// 
			this.tbChat.Location = new System.Drawing.Point(22, 18);
			this.tbChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbChat.Multiline = true;
			this.tbChat.Name = "tbChat";
			this.tbChat.ReadOnly = true;
			this.tbChat.Size = new System.Drawing.Size(320, 298);
			this.tbChat.TabIndex = 9;
			// 
			// UIGrupper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 413);
			this.Controls.Add(this.tbChat);
			this.Controls.Add(this.bntFjern);
			this.Controls.Add(this.tbMember);
			this.Controls.Add(this.bntTilføj);
			this.Controls.Add(this.tbMembers);
			this.Controls.Add(this.bntSendChat);
			this.Controls.Add(this.tbMessage);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UIGrupper";
			this.Text = "Grupper";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bntSendChat;
        private System.Windows.Forms.RichTextBox tbMembers;
        private System.Windows.Forms.Button bntTilføj;
        private System.Windows.Forms.TextBox tbMember;
        private System.Windows.Forms.Button bntFjern;
		private System.Windows.Forms.TextBox tbChat;
	}
}