using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class CrapsLogin : Form
    {
        private const string connectionString = @"Server=DESKTOP-DPMKCHR\GEORGEO;Database=Craps;Trusted_Connection=True;";
        public CrapsLogin()
        {
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string queryPlayerScore = "SELECT Players.PlayerName, Players.PlayerScore FROM dbo.Players WHERE PlayerName = '" + playerTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(queryPlayerScore, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                CrapsLogin crpLogin = new CrapsLogin();
                this.Hide();
                crpLogin.Show();
                MessageBox.Show("Successful Login");
            }
            else
            {
                MessageBox.Show("User does not exist. Make sure you enter the correct user");
            }
        }
    }
}
