namespace Client
{
    partial class UiOpretbruger
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bntOpretBruger = new System.Windows.Forms.Button();
			this.tbStatus = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(260, 72);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(226, 37);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Opret Bruger";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(195, 240);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(130, 20);
			this.textBoxPassword.TabIndex = 3;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(195, 176);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(130, 20);
			this.textBoxUsername.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(234, 223);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(229, 159);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Brugernavn";
			// 
			// bntOpretBruger
			// 
			this.bntOpretBruger.Location = new System.Drawing.Point(195, 282);
			this.bntOpretBruger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bntOpretBruger.Name = "bntOpretBruger";
			this.bntOpretBruger.Size = new System.Drawing.Size(129, 30);
			this.bntOpretBruger.TabIndex = 8;
			this.bntOpretBruger.Text = "Opret bruger";
			this.bntOpretBruger.UseVisualStyleBackColor = true;
			this.bntOpretBruger.Click += new System.EventHandler(this.BntOpretBruger_Click);
			// 
			// tbStatus
			// 
			this.tbStatus.Location = new System.Drawing.Point(195, 364);
			this.tbStatus.Name = "tbStatus";
			this.tbStatus.Size = new System.Drawing.Size(129, 20);
			this.tbStatus.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(243, 336);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Status";
			// 
			// UiOpretbruger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 396);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbStatus);
			this.Controls.Add(this.bntOpretBruger);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UiOpretbruger";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntOpretBruger;
    private System.Windows.Forms.TextBox tbStatus;
    private System.Windows.Forms.Label label5;
  }
}