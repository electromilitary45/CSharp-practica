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

            //var persona = (Nombre: "Derek", Apellido: "Leiva", Edad: 25);
            //Console.WriteLine(persona.Nombre+" "+persona.Apellido);
            //persona.Apellido = "Villalobos";
            //Console.WriteLine(persona.Nombre + " " + persona.Apellido);
            //Console.ReadKey();
            #endregion

            #region Operadores Aritmeticos
            //const int n = 10;

            //Console.WriteLine("Ingrese un numero: ");
            //int numero= int.Parse(Console.ReadLine());

            //int suma = numero + n;
            //int resta = numero - n;
            //int multiplicacion = numero * n;
            //int division = numero / n;

            //Console.WriteLine("El resultado de la suma es: " + suma);
            //Console.WriteLine("El resultado de la resta es: " + resta);
            //Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
            //Console.WriteLine("El resultado de la division es: " + division);



            //Console.ReadKey();
            #endregion

            #region Switch


            //Console.WriteLine("Ingrese un numero X: ");
            //int numerox = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese un numero Y: ");
            //int numeroy = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite 1.Sumar ,2.Restar, 3.Div, 4.multi");
            //int opcion = int.Parse(Console.ReadLine());

            //int total = 0;

            //switch (opcion) { 
            //    case 1:
            //        total=numerox+ numeroy;
            //        Console.WriteLine("{0} + {1} = {2}",numerox,numeroy,total);
            //        break;
            //    case 2:
            //        total = numerox - numeroy;
            //        Console.WriteLine("{0} - {1} = {2}", numerox, numeroy, total);
            //        break;
            //    case 3:
            //        total = numerox / numeroy;
            //        Console.WriteLine("{0} / {1} = {2}", numerox, numeroy, total);
            //        break;
            //    case 4:
            //        total = numerox * numeroy;
            //        Console.WriteLine("{0} * {1} = {2}", numerox, numeroy, total);
            //        break;
            //    default:
            //        Console.WriteLine("Opcion no valida");
            //        break;
            //}
            //Console.ReadKey();
            #endregion

            #region Clico for

            //Console.WriteLine("Digite un numero para crear su tabla de multiplicar");
            //int numero = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 11; i++)
            //{
            //    int multiplicacion = numero * i;
            //    Console.WriteLine("{0} * {1} = {2}",numero,i,multiplicacion);
            //}


            //Console.ReadKey();
            #endregion

            #region Ciclo While
            
            //Console.WriteLine("Digite un numero del 1 al 10 que de sea encontrar");
            //int numero = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (numero != i) {
            //    Console.WriteLine("No hencontrado");
            //    i++;
            //}
            //Console.WriteLine("Encontrado");
            //Console.ReadKey();

            #endregion

            #region Ciclo Do While
            
            Console.WriteLine("Digite los numeros para sumar y digite 0 para finalizar");
            int suma= 0;
            int numero;

            do { 

                try
                {
                    numero=int.Parse(Console.ReadLine());
                    suma += numero;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error al digitar el numero" + e);
                    numero = 0;
                }
            }while (numero != 0);

            Console.WriteLine("La suma es {0}",suma);

            Console.ReadKey();
            #endregion

        }
    }
}
