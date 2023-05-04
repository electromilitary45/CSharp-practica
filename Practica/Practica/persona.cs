using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class persona
    {
        #region VARIABLES
        int id;
        string nombre;
        string apellido;
        string telefono;
        #endregion

        #region CONSTRUCTORES
        public persona(){}
        public persona(int id, string nombre, string apellido,string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }
        #endregion

        #region GETTERS Y SETTERS
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        #endregion

        #region METODOS

        #endregion


    }
}
