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
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int iRnd = new int();

            iRnd = r.Next(0, 6);

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
        }
    }
}
