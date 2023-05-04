using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public enum meses { 
        Enero,
        Febrero,
        Marzo,
        Abril,
        Mayo
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            //Console.WriteLine("Bienvenido al Porgrama");
            //string nombre = "";
            //string apellido = "";
            //int edad = 0;

            //Console.WriteLine("Digite su nombre:");
            //nombre= Console.ReadLine();
            //Console.WriteLine("Digite su apellido:");
            //apellido = Console.ReadLine();
            //Console.WriteLine("Digite su edad:");
            //edad = int.Parse(Console.ReadLine());

            //Console.WriteLine("Su nombre es: " + nombre + " " + apellido + " y su edad es: " + edad);
            //Console.ReadKey();
            #endregion

            #region Tipos de Variables
            //// declaracion de variables
            //int numeroPositivod = 1;
            //int numeroNegativo = -1;
            //float numeroDecimal = 1.5f;
            //double numeroDecimal2 = 1.5;
            //decimal numeroDecimal3 = 1.5m;
            //string cadena = "Hola Mundo";
            //char caracter = 'a';
            //bool booleano = true;
            //byte numeroByte = 1;

            //char letra = cadena[0];

            #endregion

            #region Constantes y Identificadores
            ////--CONSTANTES
            //const int horasDia = 24; //este valor no se puede modificar
            //int diasMes= 30;
            //diasMes = 31;

            ////--IDENTIFICADORES




            //Console.ReadKey();
            #endregion


            #region Nullable

            //--variables
            //bool? cliente=true;
            //int? numer=null;


            //Console.ReadKey();

            #endregion

            #region ENUM
            //se tiene que declarar en el namespace para que sea visible en toda la clase
            //Console.WriteLine("Mes actual: "+meses.Enero);
            //Console.ReadKey();
            #endregion

            #region TIPOS Anonimos
            //valores readOnly
            //var persona = new { Nombre = "Juan", Apellido = "Perez" };
            //var locacion = new { Nombre = "San Salvador", Pais = "El Salvador" };

            //var persona2 = new { Nombre = "Juan", Apellido = "Perez" ,Locacion= locacion};

            //var clientes = new[] {
            //    new { Nombre = "Derek", Apellido = "Perez" ,Locacion2=locacion},
            //    new { Nombre = "Maria", Apellido = "Lopez" ,Locacion2=locacion},
            //    new { Nombre = "Pedro", Apellido = "Gomez" ,Locacion2=locacion}
            //};

            //foreach(var cliente in clientes)
            //{
            //    Console.WriteLine("Nombre: " + cliente.Nombre + " Apellido: " + cliente.Apellido + " Pais: " + cliente.Locacion2.Pais);
            //}


            //Console.ReadKey();
            #endregion


            #region TUPLAS
            //estructura de datos que permite almacenar varios valores de diferentes tipos ligera
            // es similar a JSON 

            var persona = (Nombre: "Derek", Apellido: "Leiva", Edad: 25);
            Console.WriteLine(persona.Nombre+" "+persona.Apellido);
            persona.Apellido = "Villalobos";
            Console.WriteLine(persona.Nombre + " " + persona.Apellido);
            Console.ReadKey();
            #endregion


        }
    }
}
