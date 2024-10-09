using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDB
{
    public partial class Wlogin : Form
    {
        private int rio;
        private int intentos = 0;
        public Wlogin()
        {
            InitializeComponent();
        }

        private void cmdCrearcuenta_Click(object sender, EventArgs e)
        {
            WCrearcuenta crearcuenta = new WCrearcuenta();
            crearcuenta.Show();
            this.Hide();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                rio = this.usuarios_y_ContraseñasTableAdapter.Busqueda(dB_usersDataSet.Usuarios_y_Contraseñas, txtUsuario.Text,txtContraseña.Text);

                if (rio != 0)
                {
                    MessageBox.Show("Ingresado exitosamente");
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Usario incorrecto o contraseña incorrectos \n" + "intentos restantes " + (3-intentos));

                }
                if (intentos>= 3)
                {
                    MessageBox.Show("Proteccion de cuentas activada");
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ocurrio el error" + err.Message);
            }
        }


        private void Wlogin_Load(object sender, EventArgs e)
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

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cmdLogin.Focus();

            }
        }
    }
}
