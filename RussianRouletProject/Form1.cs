using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picboxMain_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.Title;
            picboxMain.Image = Properties.Resources.rouletMain1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formTwo = new Form2();
            formTwo.Show();

            


        }
    }
}
