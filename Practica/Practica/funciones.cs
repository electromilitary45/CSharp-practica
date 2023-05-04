using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public class funciones
    {
        #region INSTACIAS
        //lista de objetos persona
        public static List<persona> lista = new List<persona>();
        
        #endregion

        #region CRUD PERSONA
        public void agregar(int id, string nombre, string apellido, string telefono)
        {

            if (!buscarPersona(id))
            {
                persona p = new persona();

                p.Id = id;
                p.Nombre = nombre;
                p.Apellido = apellido;
                p.Telefono = telefono;
                lista.Add(p);

                
                MessageBox.Show("Persona correctamente"+ p.Nombre);
            }
            else {
                MessageBox.Show("Persona creada anterior mente");        
            }
            

            
            
        }

        public static void eliminar(int id)
        {
            foreach(persona p in lista)
            {
                if (p.Id == id)
                {
                    lista.Remove(p);
                }
            }
        }

        public static void modificar(int id,string nombre,string apellido,string telefono)
        {
            if (buscarPersona(id))
            {
                lista[buscarPosicion(id)].Nombre = nombre;
                lista[buscarPosicion(id)].Apellido = apellido;
                lista[buscarPosicion(id)].Telefono = telefono;
                MessageBox.Show("Persona modificada correctamente");
            }
            else { 
                MessageBox.Show("No se encontro la persona");
            }
        }

        public string mostrar()
        {
            string s = "";
            int i = 1;
            foreach (persona p in lista)
            {
                s += "[" + i + "] " + p.Id + " " + p.Nombre + " " + p.Apellido + " " + p.Telefono + "\n";
                i++;
            }


            return s;


        }
        #endregion

        #region Funciones Persona Validacion
        public static persona DatosPersona(int id)
        {
            if (buscarPersona(id))
            {
                return lista[buscarPosicion(id)];
            }
            else
            {
                MessageBox.Show("No se encontro la persona");
                return null;
            }
        }
        public static Boolean buscarPersona(int id)
        {
            foreach(persona p in lista)
            {
                if (p.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int buscarPosicion(int id)
        {
            int i = 0;
            foreach (persona p in lista)
            {
                if (p.Id == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        #endregion

        #region funciones de validacion
        public Boolean esNumero(string n) {
            //comprobar que n sea un numero
            if (int.TryParse(n, out int number))
            {
                return true;
            }
            else { 
                return false;
            }
        }

        #endregion



        //metodo para buscar persona en la lista


    }
}
