using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDB
{
    public partial class WCrearcuenta : Form
    {
        public WCrearcuenta()
        {
            InitializeComponent();
        }

        private void cmdCrearcuenta_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarios_y_ContraseñasTableAdapter.Agregar(txtUsuario.Text, txtContraseña.Text);
                this.usuarios_y_ContraseñasTableAdapter.Fill(this.dB_usersDataSet.Usuarios_y_Contraseñas);
                MessageBox.Show("Cuenta creada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Wlogin wlogin = new Wlogin();
            wlogin.Show();
            this.Hide();
        }
      

        private void WCrearcuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_usersDataSet.Usuarios_y_Contraseñas' Puede moverla o quitarla según sea necesario.
            this.usuarios_y_ContraseñasTableAdapter.Fill(this.dB_usersDataSet.Usuarios_y_Contraseñas);

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtContraseña.Focus();

            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs i)
        {
            if (i.KeyCode == Keys.Enter)
            {
                i.SuppressKeyPress = true;
                cmdCrearcuenta.Focus();

            }
        }
    }
}
