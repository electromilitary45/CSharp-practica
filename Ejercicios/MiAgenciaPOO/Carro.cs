using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgenciaPOO
{
    class Carro : Vehiculo
    {

        #region Atributos

        int puertas;
        int acientos;

        #endregion

        #region Constructores
        public Carro() { }

        public Carro(int puertas,int acientos)
        {
            this.puertas = puertas;
            this.acientos = acientos;
        }

        #endregion
    }
}
