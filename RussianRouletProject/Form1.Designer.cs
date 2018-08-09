namespace RussianRouletProject
{
    partial class Form1
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
            this.picboxMain = new System.Windows.Forms.PictureBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxMain
            // 
            this.picboxMain.BackColor = System.Drawing.Color.Black;
            this.picboxMain.Location = new System.Drawing.Point(3, 1);
            this.picboxMain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picboxMain.Name = "picboxMain";
            this.picboxMain.Size = new System.Drawing.Size(851, 438);
            this.picboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxMain.TabIndex = 0;
            this.picboxMain.TabStop = false;
            this.picboxMain.Click += new System.EventHandler(this.picboxMain_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayGame.BackColor = System.Drawing.Color.Black;
            this.btnPlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F, System.Drawing.FontStyle.Underline);
            this.btnPlayGame.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnPlayGame.Location = new System.Drawing.Point(699, 355);
            this.btnPlayGame.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(122, 70);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Start Game >>";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F);
            this.btnExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExit.Location = new System.Drawing.Point(29, 355);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "<< Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(202, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Russian Roulet Game ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.picboxMain);
            this.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxMain;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

