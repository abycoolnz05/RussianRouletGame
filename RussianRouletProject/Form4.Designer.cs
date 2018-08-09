namespace RussianRouletProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pbLoadChamber = new System.Windows.Forms.PictureBox();
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSpinChamber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadChamber)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoadChamber
            // 
            this.pbLoadChamber.BackgroundImage = global::RussianRouletProject.Properties.Resources.spinChamber;
            this.pbLoadChamber.Location = new System.Drawing.Point(123, 30);
            this.pbLoadChamber.Name = "pbLoadChamber";
            this.pbLoadChamber.Size = new System.Drawing.Size(673, 362);
            this.pbLoadChamber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLoadChamber.TabIndex = 0;
            this.pbLoadChamber.TabStop = false;
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.BackColor = System.Drawing.Color.Black;
            this.btnSpinChamber.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F, System.Drawing.FontStyle.Underline);
            this.btnSpinChamber.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSpinChamber.Location = new System.Drawing.Point(33, 343);
            this.btnSpinChamber.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(118, 58);
            this.btnSpinChamber.TabIndex = 4;
            this.btnSpinChamber.Text = "Spin Chamber";
            this.btnSpinChamber.UseVisualStyleBackColor = false;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F);
            this.btnContinue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnContinue.Location = new System.Drawing.Point(704, 343);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(118, 58);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue >>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSpinChamber
            // 
            this.lblSpinChamber.AutoSize = true;
            this.lblSpinChamber.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinChamber.ForeColor = System.Drawing.Color.Red;
            this.lblSpinChamber.Location = new System.Drawing.Point(184, 379);
            this.lblSpinChamber.Name = "lblSpinChamber";
            this.lblSpinChamber.Size = new System.Drawing.Size(259, 13);
            this.lblSpinChamber.TabIndex = 8;
            this.lblSpinChamber.Text = "<< Spin Chamber and click continue..";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 426);
            this.Controls.Add(this.lblSpinChamber);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.pbLoadChamber);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulet Spin Chamber";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadChamber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoadChamber;
        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSpinChamber;
    }
}