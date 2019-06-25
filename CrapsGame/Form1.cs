using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class Form1 : Form
    {
        private Random r = new Random();

        private enum Status
        {
            WIN = 7,
            LOST,
            CONTINUE,
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void RollDice()
        {
            int diceOne = 0;
            int diceTwo = 0;

            diceOne = r.Next(6) + 1;
            diceTwo = r.Next(6) + 1;

            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            int iRnd = new int();
            int myPoint = 0;
            iRnd = r.Next(0, 7);
            int iRnd2 = new int();
            iRnd2 = r.Next(0, 7);
            int sum = iRnd + iRnd2;

            // Insert logic
            if (iRnd == 0)
            {
                pbDiceShow1.Image = pbDice1.Image;
            }
            else if (iRnd == 1)
            {
                pbDiceShow1.Image = pbDice2.Image;
            }
            else if (iRnd == 2)
            {
                pbDiceShow1.Image = pbDice3.Image;
            }
            else if (iRnd == 3)
            {
                pbDiceShow1.Image = pbDice4.Image;
            }
            else if (iRnd == 4)
            {
                pbDiceShow1.Image = pbDice5.Image;
            }
            else
            {
                pbDiceShow1.Image = pbDice6.Image;
            }

            iRnd = r.Next(0, 6);
            if (iRnd == 0)
            {
                pbDiceShow2.Image = pbDice1.Image;
            }
            else if (iRnd == 1)
            {
                pbDiceShow2.Image = pbDice2.Image;
            }
            else if (iRnd == 2)
            {
                pbDiceShow2.Image = pbDice3.Image;
            }
            else if (iRnd == 3)
            {
                pbDiceShow2.Image = pbDice4.Image;
            }
            else if (iRnd == 4)
            {
                pbDiceShow2.Image = pbDice5.Image;
            }
            else
            {
                pbDiceShow2.Image = pbDice6.Image;
            }


            if (sum == 7 || sum == 11)
                MessageBox.Show("You have won");
            else if (sum == 2 || sum == 3 || sum == 11)
                MessageBox.Show("Player Loses");
            else
                MessageBox.Show("Continue");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
