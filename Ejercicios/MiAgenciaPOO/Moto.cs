using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgenciaPOO
{
    class Moto : Vehiculo
    {
        #region Atributos
        bool casco;
        #endregion

        #region Constructores
        public Moto() { }

        public Moto(bool casco)
        {
            this.casco = casco;
        }

        #endregion
    }
}
