using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_user.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;

            #region login1 if
            if (user.Equals("admin") && pass.Equals("pass"))
            {
                //abrir fomulario2
                Form2 f2 = new Form2();
                f2.Show();
                
                //cerrar formulario1
                this.Hide();
            }
            else 
            { 
                MessageBox.Show("SESION INCORRECTA");
                txt_user.Text = "";
                txt_pass.Text = "";
            }
            #endregion

            #region login2 switch
                //try
                //{
                //    switch (user) {
                //        case "admin":
                //            switch (pass) {
                //                case "123":
                //                    MessageBox.Show("SESION CORRECTA");
                //                    break;
                //                case "456":
                //                    MessageBox.Show("SESION DEMA");
                //                    break;
                //                default:
                //                    MessageBox.Show("CONTRASENA INCORRECTA");
                //                    break;
                //            }
                //            break;
                //        case "client":
                //            txt_pass.Text = "HOLA CLIENTE";
                //            break;
                //        default:
                //            txt_pass.Text = "HOLA DESCONOCIDO";
                //            break;
                //    }

                //}
                //catch (Exception)
                //{

                //    throw;
                //}
                #endregion



        }//fin accion btn_submit

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
