using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace RussianRouletProject
{
    public partial class Form4 : Form

    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.Chamber);
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : Error ");
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 formFive = new Form5();
            formFive.Show();
            formFive.Text = " Fire Gun !!";
        }
    }
}
