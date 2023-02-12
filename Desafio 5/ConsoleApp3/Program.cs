using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TITULO DEL PROGRAMA
            Console.Title = "Programa de calculo de bandas de resistencias";
            //DECLARACION DE VARIABLES
            string banda1, banda2, banda1_2, banda3_text, banda4_text;
            char banda3, banda4 ;
            double num_banda1_2, numb_banda3 = 0, banda_totals;
           

            //DATOS DE ENTRADA
           
            Console.WriteLine("---------------Colores de las bandas:---------------------");
            Console.WriteLine(" \n0-negro  \n1-Marron \n2-Rojo  \n3-Naranja  \n4-Amarillo  \n5-Verde  \n6-Azul \n7-violeta  \n8-gris  \n9-blanco ");
            Console.WriteLine("\n digite el color de la primer banda");
            banda1 = Console.ReadLine();
            Console.WriteLine("Digite el color de la segunda banda");
            banda2 = Console.ReadLine();
            Console.WriteLine("Digite el color de la tercera banda");
            banda3_text = Console.ReadLine();
            Console.WriteLine("\n---------------Colores de la banda 4 **tolerancia**:-----------------");
            Console.WriteLine("  \n1-Marron \n2-Rojo  \n3-Naranja  \n4-Amarillo  \n5-Verde  \n6-Azul \n7-Violeta  \n8-Gris  \n9-Plata \nA-Oro \nJ-Ninguno ");
            Console.WriteLine("digite el color de la cuarta banda");
            banda4_text = Console.ReadLine();
            Console.WriteLine("\n");
         

            banda1_2 = banda1 + banda2;
            num_banda1_2 = double.Parse(banda1_2);
            banda3 = Char.Parse(banda3_text);
            banda4 = Char.Parse(banda4_text);

            //FUNCIONAMIENTO DEL SWITCH
            switch (banda3)
            {

                case '0' :
                    numb_banda3= 1;
                    Console.WriteLine("El prefijo es: " + "Ohms");
                    break;

                case '1':
                    numb_banda3 = 10;
                    Console.WriteLine("El prefijo es: " + "Ohms");
                    break;

                case '2':
                    numb_banda3 = 100;
                    Console.WriteLine("El prefijo es: " + "Kilos Ohms");
                    break;

                case '3':
                    numb_banda3 = 1000;
                    Console.WriteLine("El prefijo es: " + "Kilos Ohms");
                    break;

                case '4':
                    numb_banda3 = 10000;
                    Console.WriteLine("El prefijo es: " + "Kilos Ohms");
                    break;

                case '5':
                    numb_banda3 = 100000;
                    Console.WriteLine("El prefijo es: " + "Kilos Ohms");
                    break;

                case '6':
                    numb_banda3 = 1000000;
                    Console.WriteLine("El prefijo es: " + "Mega Ohms");
                    break;

                case '7':
                    numb_banda3 = 10000000;
                    Console.WriteLine("El prefijo es: " + "Mega Ohms");
                    break;

                case '8':
                    numb_banda3 = 100000000;
                    Console.WriteLine("El prefijo es: " + "Mega Ohms");
                    break;

                case '9':
                    numb_banda3 = 1000000000;
                    Console.WriteLine("El prefijo es: " + "Giga Ohms");
                    break;
              


            }

               
                switch (banda4)
            {
                

                case '1':


                    Console.WriteLine("La toleracias es: " + "±1 %");
                    break;

                case '2':


                    Console.WriteLine("La toleracias es: " + "±2 %");
                    break;

                case '3':


                    Console.WriteLine("La toleracias es: " + "±0.05 %");
                    break;

                case '4':


                    Console.WriteLine("La toleracias es: " + "±0.02 %");
                    break;

                case '5':


                    Console.WriteLine("La toleracias es: " + "±0.5 %");
                    break;

                case '6':


                    Console.WriteLine("La toleracias es: " + "±0.25 %");
                    break;

                case '7':


                    Console.WriteLine("La toleracias es: " + "±0.1 %");
                    break;

                case '8':


                    Console.WriteLine("La toleracias es: " + "±0.01 %");
                    break;

                case '9':


                    Console.WriteLine("La toleracias es: " + "±10 %");
                    break;


                case 'A':


                    Console.WriteLine("La toleracias es: " + "±5 %");
                    break;


                case 'J':


                    Console.WriteLine("La toleracias es: " + "±20 %");
                    break;

               
            }
            
            banda_totals = num_banda1_2 * numb_banda3;

           
            Console.Write("El valor de la resistencia: "  + banda_totals );
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-DESARROLLADO POR ALISSON CASTRO");
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadKey();
        }
    }
}
