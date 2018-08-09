using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletProject
{
    public partial class Form3 : Form
    {
        //public Functions AllFunctions = new Functions();
        public Form3()
        {
            InitializeComponent();
        }
         
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void pbLoadGun_Click(object sender, EventArgs e)
        {
               

        }

        private void btnLoadBullet_Click_1(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundplayer = new SoundPlayer(Properties.Resources.Load);
                soundplayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": This Error");
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 formFour = new Form4();
            formFour.Show();
            formFour.Text = " Please Spin The Chamber Of Your Gun !!";
        }
    }
}
