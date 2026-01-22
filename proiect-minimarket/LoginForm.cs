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

namespace proiect_minimarket
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Crimson;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Navy;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Crimson;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Navy;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please enter your username and password", "Invalid username and password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex > -1)
                {
                    if (comboBox_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (TextBox_username.Text == "Admin" && TextBox_password.Text == "Admin123")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
                else
                {
                    MessageBox.Show("Please select role", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
