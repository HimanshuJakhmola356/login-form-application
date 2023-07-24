using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Form_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Connection String
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-49O23E5;Initial Catalog=MyDataBase;Integrated Security=True");
        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

      

        private void button_login_Click_1(object sender, EventArgs e)
        {

            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;


            /////////////////////////////////////////////////////////////////////
            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '"+txt_username.Text+"' AND password = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if(dataTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    MessageBox.Show("login successful!, Welcome Back " + username);

                    //page that needed to be load next
                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("invalid username or password. please try again.");
                        txt_username.Clear();
                        txt_password.Clear();

                    // to focus username
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            
            txt_username.Focus();
        }
    }
}
