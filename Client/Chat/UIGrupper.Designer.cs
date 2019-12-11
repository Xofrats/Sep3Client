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
            this.textBoxTilføj = new System.Windows.Forms.TextBox();
            this.bntFjern = new System.Windows.Forms.Button();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(29, 602);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(609, 104);
            this.tbMessage.TabIndex = 1;
            // 
            // bntSendChat
            // 
            this.bntSendChat.Location = new System.Drawing.Point(221, 711);
            this.bntSendChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntSendChat.Name = "bntSendChat";
            this.bntSendChat.Size = new System.Drawing.Size(195, 54);
            this.bntSendChat.TabIndex = 2;
            this.bntSendChat.Text = "Send";
            this.bntSendChat.UseVisualStyleBackColor = true;
            this.bntSendChat.Click += new System.EventHandler(this.bntSendChat_Click);
            // 
            // tbMembers
            // 
            this.tbMembers.Location = new System.Drawing.Point(675, 22);
            this.tbMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMembers.Name = "tbMembers";
            this.tbMembers.ReadOnly = true;
            this.tbMembers.Size = new System.Drawing.Size(241, 559);
            this.tbMembers.TabIndex = 3;
            this.tbMembers.Text = "";
            // 
            // bntTilføj
            // 
            this.bntTilføj.Location = new System.Drawing.Point(823, 710);
            this.bntTilføj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntTilføj.Name = "bntTilføj";
            this.bntTilføj.Size = new System.Drawing.Size(69, 57);
            this.bntTilføj.TabIndex = 6;
            this.bntTilføj.Text = "Tilføj";
            this.bntTilføj.UseVisualStyleBackColor = true;
            this.bntTilføj.Click += new System.EventHandler(this.BntTilføj_Click);
            // 
            // textBoxTilføj
            // 
            this.textBoxTilføj.Location = new System.Drawing.Point(675, 665);
            this.textBoxTilføj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTilføj.Name = "textBoxTilføj";
            this.textBoxTilføj.Size = new System.Drawing.Size(241, 22);
            this.textBoxTilføj.TabIndex = 7;
            // 
            // bntFjern
            // 
            this.bntFjern.Location = new System.Drawing.Point(675, 710);
            this.bntFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntFjern.Name = "bntFjern";
            this.bntFjern.Size = new System.Drawing.Size(69, 57);
            this.bntFjern.TabIndex = 8;
            this.bntFjern.Text = "Fjern";
            this.bntFjern.UseVisualStyleBackColor = true;
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(29, 22);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(609, 559);
            this.tbChat.TabIndex = 9;
            // 
            // UIGrupper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 778);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.bntFjern);
            this.Controls.Add(this.textBoxTilføj);
            this.Controls.Add(this.bntTilføj);
            this.Controls.Add(this.tbMembers);
            this.Controls.Add(this.bntSendChat);
            this.Controls.Add(this.tbMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox textBoxTilføj;
        private System.Windows.Forms.Button bntFjern;
		private System.Windows.Forms.TextBox tbChat;
	}
}