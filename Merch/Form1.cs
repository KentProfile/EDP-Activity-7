
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Merch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void submit_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost; userid=root; password=kentbuit13; database=circo";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string stm = "SELECT Username, Password FROM Login WHERE Username = @username AND Password = @password";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@username", name.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);


                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    dashboards();

                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password."); // Display message to the user
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message); // Display error message to the user
            }
            finally
            {
                con.Close();
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dashboards()
        {
            this.Hide();
            dashboards frm = new dashboards();
            frm.ShowDialog();
            this.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {

        }
    }
}

