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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntSendChat = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bntTilføj = new System.Windows.Forms.Button();
            this.textBoxTilføj = new System.Windows.Forms.TextBox();
            this.bntFjern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(609, 559);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 602);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 104);
            this.textBox1.TabIndex = 1;
            // 
            // bntSendChat
            // 
            this.bntSendChat.Location = new System.Drawing.Point(222, 712);
            this.bntSendChat.Name = "bntSendChat";
            this.bntSendChat.Size = new System.Drawing.Size(195, 54);
            this.bntSendChat.TabIndex = 2;
            this.bntSendChat.Text = "Send";
            this.bntSendChat.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(674, 22);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(241, 559);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // bntTilføj
            // 
            this.bntTilføj.Location = new System.Drawing.Point(823, 710);
            this.bntTilføj.Name = "bntTilføj";
            this.bntTilføj.Size = new System.Drawing.Size(69, 56);
            this.bntTilføj.TabIndex = 6;
            this.bntTilføj.Text = "Tilføj";
            this.bntTilføj.UseVisualStyleBackColor = true;
            this.bntTilføj.Click += new System.EventHandler(this.BntTilføj_Click);
            // 
            // textBoxTilføj
            // 
            this.textBoxTilføj.Location = new System.Drawing.Point(674, 664);
            this.textBoxTilføj.Name = "textBoxTilføj";
            this.textBoxTilføj.Size = new System.Drawing.Size(241, 22);
            this.textBoxTilføj.TabIndex = 7;
            // 
            // bntFjern
            // 
            this.bntFjern.Location = new System.Drawing.Point(674, 710);
            this.bntFjern.Name = "bntFjern";
            this.bntFjern.Size = new System.Drawing.Size(69, 56);
            this.bntFjern.TabIndex = 8;
            this.bntFjern.Text = "Fjern";
            this.bntFjern.UseVisualStyleBackColor = true;
            // 
            // UIGrupper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 778);
            this.Controls.Add(this.bntFjern);
            this.Controls.Add(this.textBoxTilføj);
            this.Controls.Add(this.bntTilføj);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.bntSendChat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "UIGrupper";
            this.Text = "Grupper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntSendChat;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button bntTilføj;
        private System.Windows.Forms.TextBox textBoxTilføj;
        private System.Windows.Forms.Button bntFjern;
    }
}