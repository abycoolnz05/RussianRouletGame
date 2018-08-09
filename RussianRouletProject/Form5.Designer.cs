namespace RussianRouletProject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pbHuman = new System.Windows.Forms.PictureBox();
            this.pbfireGun = new System.Windows.Forms.PictureBox();
            this.btnFireGun = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lbxScore = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfireGun)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHuman
            // 
            this.pbHuman.BackColor = System.Drawing.Color.Transparent;
            this.pbHuman.BackgroundImage = global::RussianRouletProject.Properties.Resources.human;
            this.pbHuman.Location = new System.Drawing.Point(-7, 12);
            this.pbHuman.Name = "pbHuman";
            this.pbHuman.Size = new System.Drawing.Size(414, 402);
            this.pbHuman.TabIndex = 0;
            this.pbHuman.TabStop = false;
            this.pbHuman.Click += new System.EventHandler(this.pbHuman_Click);
            // 
            // pbfireGun
            // 
            this.pbfireGun.BackgroundImage = global::RussianRouletProject.Properties.Resources.revolver_bullet;
            this.pbfireGun.Location = new System.Drawing.Point(292, -1);
            this.pbfireGun.Name = "pbfireGun";
            this.pbfireGun.Size = new System.Drawing.Size(237, 186);
            this.pbfireGun.TabIndex = 1;
            this.pbfireGun.TabStop = false;
            // 
            // btnFireGun
            // 
            this.btnFireGun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFireGun.BackColor = System.Drawing.Color.Black;
            this.btnFireGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFireGun.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireGun.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnFireGun.Location = new System.Drawing.Point(549, 42);
            this.btnFireGun.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFireGun.Name = "btnFireGun";
            this.btnFireGun.Size = new System.Drawing.Size(211, 84);
            this.btnFireGun.TabIndex = 8;
            this.btnFireGun.Text = "<< Fire Gun";
            this.btnFireGun.UseVisualStyleBackColor = false;
            this.btnFireGun.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(597, 165);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 20);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "- Win / Loose-";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxScore
            // 
            this.lbxScore.BackColor = System.Drawing.Color.White;
            this.lbxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxScore.ForeColor = System.Drawing.Color.Maroon;
            this.lbxScore.FormattingEnabled = true;
            this.lbxScore.Location = new System.Drawing.Point(487, 189);
            this.lbxScore.Name = "lbxScore";
            this.lbxScore.Size = new System.Drawing.Size(339, 225);
            this.lbxScore.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 426);
            this.Controls.Add(this.lbxScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnFireGun);
            this.Controls.Add(this.pbfireGun);
            this.Controls.Add(this.pbHuman);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firing Chamber";
            ((System.ComponentModel.ISupportInitialize)(this.pbHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfireGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHuman;
        private System.Windows.Forms.PictureBox pbfireGun;
        private System.Windows.Forms.Button btnFireGun;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ListBox lbxScore;
    }
}