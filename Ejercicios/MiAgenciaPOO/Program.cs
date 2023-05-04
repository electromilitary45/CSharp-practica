using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgenciaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title="Mi Agencia";
            Console.WriteLine("Digite una opcion a ingresar \n 1.Moto \n2.Carro");
            int opcion = int.Parse(Console.ReadLine());
           

            switch (opcion) {
                case 1:
                    Console.WriteLine("Moto");
                    break;
                case 2: 
                    Vehiculo vehiculo = new Vehiculo();
                    Console.WriteLine("Carro");
                    //---variables
                    int id,precio, anio;
                    string modelo, color, status;

                    Console.WriteLine("Digite el ID del vehiculo:");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el modelo del vehiculo");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Digite el precio del vehiculo");
                    precio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el año del vehiculo");
                    anio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el color del vehiculo");
                    color = Console.ReadLine();
                    Console.WriteLine("Digite el status del vehiculo (Disponible || Agotado)");
                    status = Console.ReadLine();

                    vehiculo.Id = id;
                    vehiculo.Modelo = modelo;
                    vehiculo.Precio = precio;
                    vehiculo.Anio = anio;
                    vehiculo.Color = color;
                    vehiculo.Status = status;

                    string mensaje = vehiculo.Ingresar();

                    Console.WriteLine(mensaje);

                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }//fin switch

            Console.ReadKey();
        }//fin main
    }//fin class
}//fin namespace
