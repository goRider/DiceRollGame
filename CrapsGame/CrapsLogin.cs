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
            using (var conn = new SqlConnection(connectionString))
            {
                string queryPlayerScore = "INSERT INTO Players (PlayerName) VALUES ('" + playerTextBox.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(queryPlayerScore, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            using (var conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Players.PlayerName, Players.PlayerScore FROM dbo.Players WHERE PlayerName = '" + playerTextBox.Text.Trim() + "'"))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.Add("PlayerName", SqlDbType.NVarChar).Value = playerTextBox.Text.Trim();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.FieldCount != 0)
                        {
                            Form1 frm = new Form1();
                            CrapsLogin crpLogin = new CrapsLogin();
                            this.Hide();
                            crpLogin.Show();
                            frm.Show();
                            MessageBox.Show("Successful Login");
                        }
                        else
                        {
                            MessageBox.Show("User does not exist. Make sure you enter the correct user");
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void ClearPlayerScoreHistoryButton_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE Players FROM dbo.Players WHERE PlayerScore = @PlayerScore"))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.FieldCount != 0)
                        {
                            cmd.Parameters.Add("PlayerScore", SqlDbType.VarChar);
                            MessageBox.Show("Player Score history is clear");
                        }
                        else
                        {
                            MessageBox.Show("Active Player score");
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrapsLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crapsDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.crapsDataSet.Players);

        }
    }
}
