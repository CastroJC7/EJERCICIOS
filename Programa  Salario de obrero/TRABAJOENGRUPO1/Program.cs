using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJOENGRUPO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Porgrama que calcula el salario semanal de un obrero");
            Console.Write("\n");
            //Declaración de variables
            Double salario, horaTrabajada, tarifa, horaExtra;
            //Proceso
            Console.WriteLine("Ingrese las horas trabajadas durante la semana");
            horaTrabajada = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tarifa por hora");
            tarifa = Double.Parse(Console.ReadLine());

            if (horaTrabajada <= 30 )
            {
                salario = tarifa * horaTrabajada;
                Console.WriteLine("Su salario semanal es: $" + salario.ToString("F2"));
            }
            else
            {
               horaExtra  = (horaTrabajada -30) * (tarifa * 1.25);
                salario = (30 * tarifa) + horaExtra;
                Console.WriteLine("Su salario semanal más horas extra es: $" + salario.ToString("F2"));
            }
            Console.ReadKey();
        
        }
    }
}
