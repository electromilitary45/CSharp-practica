using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgenciaPOO
{
    
    public class Vehiculo
    {
        #region Atributos

        int id;
        string modelo;
        int precio;
        int anio;
        string color;
        string status;


        #endregion

        #region Constructores
        public Vehiculo() { }
        public Vehiculo(int id,string modelo, int precio, int anio, string color, string status)
        {
            this.id = id;
            this.modelo =modelo;
            this.precio = precio;
            this.anio = anio;
            this.color = color;
            this.status = status;
        }

        #endregion

        #region Metodos

        public string Ingresar() {
            try
            {
                //Console.WriteLine("Digite el ID del vehiculo:");
                //id = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite el modelo del vehiculo");
                //modelo = Console.ReadLine();
                //Console.WriteLine("Digite el precio del vehiculo");
                //precio = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite el año del vehiculo");
                //anio = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite el color del vehiculo");
                //color = Console.ReadLine();
                //Console.WriteLine("Digite el status del vehiculo (Disponible || Agotado)");
                //status = Console.ReadLine();

                //Carro carro = new Carro();
                //carro.id = id;
                //carro.modelo = modelo;


            }catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
            

            return "Ingresado";
            
        }

        public string vender() { 
            return "Vendido";
        }

        #endregion

        #region GET Y SET
        public int Id { get; set; }

        public string Modelo { get; set; }

        public int Precio { get; set; }
        public int Anio { get; set; }

        public string Color { get; set; }

        public string Status { get;set;}
        #endregion 



    }
}
