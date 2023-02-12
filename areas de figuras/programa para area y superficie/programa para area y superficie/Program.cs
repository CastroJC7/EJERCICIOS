using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_para_area_y_superficie
{
    class Program
    {
        static void Main(string[] args)
        {
  Console.WindowHeight = 25; 
            
Console.WindowWidth = 70; 
            
Console.ForegroundColor = ConsoleColor.Black;
            
Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            
Console.Title = "Programa para saber la superficie y  el area figuras gemeotricas ";

            Console.WriteLine("" +
                " saber areas de cono,piramide y esfera  ");
            int op;
            //a es una variable universal para las 3 figuras geometricas 
            // b es para los datos que piden mas de un valor
            // c es para guardar el valor del radio

            double a,resul1 , b, c ;
            Console.WriteLine("   escoja un cuerpo geometrico  ");
            Console.WriteLine("           1.esfera");
            Console.WriteLine("           2.piramide");
            Console.WriteLine("           3.cono");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("ingrese el radio de la esfera : ");
                    a = double.Parse(Console.ReadLine());
                    //formula para encontrar 
                    resul1 = 4 * Math.PI*(Math.Pow(a, 2));
                    Console.Write("el resultado es: "+resul1);
             
                    break;
                case 2:
                    Console.Write("ingrese una base: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("ingrese la alutura ");
                    b = double.Parse(Console.ReadLine());
                    resul1 = (a * b) / 2;
                    Console.Write("el area es:"+resul1 );
               
                    break;
                case 3:
                    Console.Write("ingrese la altura del cono:");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("ingrese la generatris:");
                    b = double.Parse(Console.ReadLine());
                    //esta formula es para el radio
                  c = Math.Pow(a, 2)*Math.Pow(b,2);
                    //saca la  raiz
                    c = Math.Sqrt(c);
                    //area lateral
                    resul1 = 3.1416 * (b * c);
                    //encuentra el area total
                    resul1 = resul1 + 3.1416 * (Math.Pow(c, 2));
                    Console.Write("el area total es  "+resul1);
                    

                    break;
                default:
                    break;
            }

            Console.ReadKey();


        }
    }
}
