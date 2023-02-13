using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL404_DESAFIO_PRACTICO1_EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por
            // Día: Enero 18,2023
            Console.WindowHeight = 45;
            Console.WindowWidth = 100; // ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa para determinar el resultado de la compuerta lógica XOR y de una NAND";
            Console.Write("\n\nPractico 1 ejercicio3");
            Console.Write("\n\n");
            Console.Write("\tAveriguaremos el resultado de la compuerta lógica XOR y NAND...");
            Console.Write("\n\n");

            // Declaracion de variables
            int op;
            Char x, y;

  
            // Aqui diseñamos nuestro menú principal
            Console.WriteLine("\t============================================== ");
            Console.WriteLine("\tELECTRÓNICA BÁSICA");
            Console.Write("\n");
            Console.WriteLine("\t 1. Compuerta Lógica XOR");
            Console.Write("\n");
            Console.WriteLine("\t 2. Compuerta Lógica NAND");
            Console.Write("\n");
            Console.WriteLine("\t 3. Resultado de Ambas");
            Console.Write("\n");
            Console.WriteLine("\t 4. SALIR DEL PROGRAMA");
            Console.WriteLine("\t============================================== ");
            Console.WriteLine("\n");
            Console.Write("\tDigite su opcion del [ 1 al 4 ]: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Entrada de datos
            Console.Write("\tIngrese el valor \"V / v\" Verdadero o el valor \"F / f\" falso...");
            Console.Write("\n\n");
            Console.Write("\tDigitar el primer valor : ");
            x = Convert.ToChar(Console.ReadLine());
            Console.Write("\tDigitar el segundo valor: ");
            y = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            // Aqui funciona el switch con sus cases
            switch (op)
            {
                case 1:
                    if (x == 'F' || x == 'f' && y == 'F' || y == 'f')
                    {
                        Console.WriteLine("\t El resultado es: F");
                    }
                    else if (x == 'F' || x == 'f' && y == 'V' || y == 'v')
                    {
                        Console.WriteLine("\t El resultado es: V");
                    }
                    else if (x == 'V' || x == 'v' && y == 'F' || y == 'f')
                    {
                        Console.WriteLine("\t El resultado es: V");
                    }
                    else if (x == 'V' || x == 'v' && y == 'V' || y == 'v')
                    {
                        Console.WriteLine("\t El resultado es: F");
                    }
                    else
                    {
                        Console.WriteLine("\t--> no ha ingresado un valor verdadero o falso" );
                    }
                    break;
                    case 2:
                    if (x == 'F' || x == 'f' && y == 'F' || y == 'f')
                    {
                        Console.WriteLine("\t El resultado es: V");
                    }
                    else if (x == 'F' || x == 'f' && y == 'V' || y == 'v')
                    {
                        Console.WriteLine("\t El resultado es: V");
                    }
                    else if (x == 'V' || x == 'v' && y == 'F' || y == 'f')
                    {
                        Console.WriteLine("\t El resultado es: V");
                    }
                    else if (x == 'V' || x == 'v' && y == 'V' || y == 'v')
                    {
                        Console.WriteLine("\t El resultado es: F");
                    }
                    else
                    {
                        Console.WriteLine("\t--> no ha ingresado un valor verdadero o falso");
                    }
                    break;
                   case 3:
                    if (x == 'f' || x == 'v' && y == 'f' || y == 'v')
                    {
                        Console.WriteLine("\t El resultado es: ");
                        Console.WriteLine("\t");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   Compuerta logica XOR   *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   A    *   B   *  Resul  *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   F    *   F   *     F   *");
                        Console.WriteLine("\t*   F    *   V   *     V   *");
                        Console.WriteLine("\t*   V    *   F   *     V   *");
                        Console.WriteLine("\t*   V    *   V   *     F   *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t");
                        Console.Write("\n");
                        Console.WriteLine("\t");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   Compuerta logica NAND  *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   A    *   B   *  Resul  *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t*   F    *   F   *     V   *");
                        Console.WriteLine("\t*   F    *   V   *     V   *");
                        Console.WriteLine("\t*   V    *   F   *     V   *");
                        Console.WriteLine("\t*   V    *   V   *     F   *");
                        Console.WriteLine("\t****************************");
                        Console.WriteLine("\t");
                    }
                    else
                    {
                        Console.WriteLine("\t--> no ha ingresado un valor verdadero o falso");
                    }
                    break;
                case 4:
                    Environment.Exit(0); // esta instruccion se sale de un solo del programa
                    break;
                default:
                    Console.WriteLine("\t Opcion no definida.. intente de nuevo");
                    break;
            }
            Console.Write("\n\n");

            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
    }
}
