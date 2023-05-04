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
    public partial class Form2 : Form
    {
        public static funciones f = new funciones();
        public persona p;
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //comprobar que el textbox sea un numero

                if (!txt_id.Text.Equals("") && f.esNumero(txt_id.Text) && !txt_nombre.Text.Equals("") && !txt_apellido.Text.Equals("") && !txt_telefono.Text.Equals(""))
                {
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string telefono = txt_telefono.Text;
                    int id = int.Parse(txt_id.Text);

                    f.agregar(id, nombre, apellido, telefono);

                }
                else
                {
                    MessageBox.Show("ERROR");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            txta_lista.Text = f.mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (f.esNumero(txt_id.Text))
            {

                p = funciones.DatosPersona(int.Parse(txt_id.Text));

                if (p != null)
                {
                    txt_nombre.Text = p.Nombre;
                    txt_apellido.Text = p.Apellido;
                    txt_telefono.Text = p.Telefono;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (f.esNumero(txt_id.Text))
            {

                funciones.modificar(int.Parse(txt_id.Text), txt_nombre.Text, txt_apellido.Text, txt_telefono.Text);
            }
            else { 
                MessageBox.Show("No digito un id correcto");
            }
        }//fin modificar 
    }
}
