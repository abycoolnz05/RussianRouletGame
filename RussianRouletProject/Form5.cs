using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RussianRouletProject
{
    public partial class Form5 : Form
    {
  
   
        public Form5()
        {
            InitializeComponent();
        }

        private void pbHuman_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int[] fireBullet = new int[]{ 0, 0, 0, 0, 0, 0 }; //define an array

            Random myrandom = new Random();  // Generates a Random Number
            int gunChamber = myrandom.Next(0, 6);  //Puts the random # in a var gun chamber

            fireBullet[gunChamber] = 1;  //Gun chamber randomly in array firebullet

            bool gameOver = true;  //Game Over exits the game
            
            int counter = 0;
         
            do           //Loop 
            {                  
                if (fireBullet[counter] == 1 )
                {
                    SoundPlayer soundplayer = new SoundPlayer(Properties.Resources.Fire);  //Sound Player
                    soundplayer.Play();                  
                    lbxScore.Items.Add(  "  :-(   * Bang !! " + " Sorry You Died & Lost The Game ! " );
                    lbxScore.Items.Add(" ");
                    counter++;
                    gameOver = true;


                }
                else if (fireBullet[counter] == 0)
                {                    
                    lbxScore.Items.Add( " :-)   Great! You Miss The Bullet and Win! " );                   
                    lbxScore.Items.Add( "       - Click - * Fire Gun to play again* ! ");
                    lbxScore.Items.Add(" ");
                    gameOver = true;
                }
            } while ( gameOver == false);   //while game over is false
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


