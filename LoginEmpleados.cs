using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Menu
{
    public partial class LoginEmpleados : Form
    {
        public LoginEmpleados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnusername_Enter(object sender, EventArgs e)
        {
            if (btnusername.Text == "USERNAME"){
                btnusername.Text = "";
                btnusername.ForeColor = Color.LightGray;
            }
        }

        private void btnusername_Leave(object sender, EventArgs e)
        {
            if (btnusername.Text==""){
                btnusername.Text = "USERNAME";
                btnusername.ForeColor = Color.DimGray;
            }
        }

        private void btnpass_Enter(object sender, EventArgs e)
        {
            if (btnpass.Text==""){
                btnpass.Text = "PASSWORD";
                btnpass.ForeColor = Color.LightGray;
                btnpass.UseSystemPasswordChar = true;
            }
        }

        private void btnpass_Leave(object sender, EventArgs e)
        {
            if (btnpass.Text=="") {
                btnpass.Text = "PASSWORD";
                btnpass.ForeColor = Color.DimGray;
                btnpass.UseSystemPasswordChar = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
        }

    }
}
