namespace RussianRouletProject
{
    partial class Form3
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
            this.pbLoadGun = new System.Windows.Forms.PictureBox();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblLoadBullet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadGun)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoadGun
            // 
            this.pbLoadGun.BackgroundImage = global::RussianRouletProject.Properties.Resources.loadGun;
            this.pbLoadGun.Location = new System.Drawing.Point(66, -1);
            this.pbLoadGun.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbLoadGun.Name = "pbLoadGun";
            this.pbLoadGun.Size = new System.Drawing.Size(621, 506);
            this.pbLoadGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadGun.TabIndex = 0;
            this.pbLoadGun.TabStop = false;
            this.pbLoadGun.Click += new System.EventHandler(this.pbLoadGun_Click);
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.Color.Black;
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F, System.Drawing.FontStyle.Underline);
            this.btnLoadBullet.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnLoadBullet.Location = new System.Drawing.Point(43, 422);
            this.btnLoadBullet.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(118, 58);
            this.btnLoadBullet.TabIndex = 3;
            this.btnLoadBullet.Text = "Load Bullet";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click_1);
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F);
            this.btnContinue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnContinue.Location = new System.Drawing.Point(705, 408);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(118, 58);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue >>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblLoadBullet
            // 
            this.lblLoadBullet.AutoSize = true;
            this.lblLoadBullet.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadBullet.ForeColor = System.Drawing.Color.Red;
            this.lblLoadBullet.Location = new System.Drawing.Point(166, 453);
            this.lblLoadBullet.Name = "lblLoadBullet";
            this.lblLoadBullet.Size = new System.Drawing.Size(252, 13);
            this.lblLoadBullet.TabIndex = 7;
            this.lblLoadBullet.Text = "<< Load Bullet and click continue..";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 504);
            this.Controls.Add(this.lblLoadBullet);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.pbLoadGun);
            this.Font = new System.Drawing.Font("Microsoft Office Preview Font", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulet Main - Welcome";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoadGun;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblLoadBullet;
    }
}