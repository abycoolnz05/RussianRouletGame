namespace RussianRouletProject
{
    partial class Form2
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblProfilePic = new System.Windows.Forms.Label();
            this.cboxProfilePictures = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbForm2Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm2Main)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Office Preview Font", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(147, 190);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(202, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Please Enter A Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(474, 190);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblProfilePic
            // 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.BackColor = System.Drawing.Color.Black;
            this.lblProfilePic.Font = new System.Drawing.Font("Microsoft Office Preview Font", 12F);
            this.lblProfilePic.ForeColor = System.Drawing.Color.Red;
            this.lblProfilePic.Location = new System.Drawing.Point(147, 259);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(245, 21);
            this.lblProfilePic.TabIndex = 2;
            this.lblProfilePic.Text = "Please Choose Your Age Group :";
            // 
            // cboxProfilePictures
            // 
            this.cboxProfilePictures.BackColor = System.Drawing.Color.Snow;
            this.cboxProfilePictures.ForeColor = System.Drawing.Color.Black;
            this.cboxProfilePictures.FormattingEnabled = true;
            this.cboxProfilePictures.Location = new System.Drawing.Point(474, 262);
            this.cboxProfilePictures.Name = "cboxProfilePictures";
            this.cboxProfilePictures.Size = new System.Drawing.Size(161, 21);
            this.cboxProfilePictures.TabIndex = 3;
            this.cboxProfilePictures.SelectedIndexChanged += new System.EventHandler(this.cboxProfilePictures_SelectedIndexChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F, System.Drawing.FontStyle.Underline);
            this.btnContinue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnContinue.Location = new System.Drawing.Point(703, 353);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(118, 58);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue >>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F);
            this.btnExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExit.Location = new System.Drawing.Point(23, 353);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 58);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "<< Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbForm2Main
            // 
            this.pbForm2Main.BackgroundImage = global::RussianRouletProject.Properties.Resources.rouletMain;
            this.pbForm2Main.Location = new System.Drawing.Point(23, 23);
            this.pbForm2Main.Name = "pbForm2Main";
            this.pbForm2Main.Size = new System.Drawing.Size(806, 142);
            this.pbForm2Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbForm2Main.TabIndex = 7;
            this.pbForm2Main.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 426);
            this.Controls.Add(this.pbForm2Main);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cboxProfilePictures);
            this.Controls.Add(this.lblProfilePic);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulet ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbForm2Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblProfilePic;
        private System.Windows.Forms.ComboBox cboxProfilePictures;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbForm2Main;
    }
}