using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
           
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Productos()); //enviamos como parametro nuestro formulario como nuevo objeto
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btninicio_Click(null, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnReportes_Click (object sender, EventArgs e)
        {
           SubmenuReportes.Visible = !SubmenuReportes.Visible;
        }

        private void btnrptventas_Click(object sender, EventArgs e)
        {
            //SubmenuReportes.Visible = false;
        }

        private void btnrptcompras_Click(object sender, EventArgs e)
        {
            //SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
              //SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       private void AbrirFromHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form; //creamos el formulario
            fh.TopLevel = false; //con esto decimos que no es un formulario de nivel superior sino secundario.
            fh.Dock = DockStyle.Fill; //esto hace que se acople a todo el panel contenedor.
            this.panelContenedor.Controls.Add(fh); //lo agregamos 
            this.panelContenedor.Tag = fh; //establecemos la instancia a nuestro panel
            fh.Show(); //se muestra
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Productos());
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new inicio());
        }
        private void btnclientes_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Clientes());
        }
        private void btncompras_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Compras());
        }
        private void btnventas_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Ventas());
        }
        private void btnpagos_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new FormCompras());
        }
        
        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new LoginEmpleados());
        }
        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new Proveedores());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new Devoluciones());
        }

    }
}
