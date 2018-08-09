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
    public partial class Form2 : Form
    {
        public Functions AllFunctions = new Functions(); //instantiate a new class
        
        public Form2()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCombobox() // Function Combobox
        {
            cboxProfilePictures.Items.AddRange(AllFunctions.LoadAgeStrings());           
            cboxProfilePictures.SelectedIndex = 0;
        }
 
        private void cboxProfilePictures_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
             var userName = txtUsername.Text;
             if (userName == "")
             {
                MessageBox.Show("Please Enter A 'Username'");
             }
            else
             {
                this.Hide();
                Form3 formThree = new Form3();
                formThree.Show();
                formThree.Text = " Welcome ! " +  userName + " - Click on Load Bullet Button !! ";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
