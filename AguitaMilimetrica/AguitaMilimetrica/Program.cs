using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguitaMilimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa llamado “cantidadAgua” con interfaz para consola en C# .NET que permita ingresar por teclado la cantidad de agua caída,
            //en milímetros día a día durante un mes. Imprimir en pantalla la información correspondiente al día de mayor lluvia, el de menor y el promedio.

            //Saludo e introduzco al programa
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Buen día, bienvenido al programa");
            Console.WriteLine("Este programa evalúa los datos ingresados de la cantidad de agua caída durante un mes");
            Console.WriteLine("=========================================================================================");

            //Creo vector que se encargará de recolectar la cantidad de agua durante 30 días
            double[] aguaCaida = new double[30];

            //Ciclo que captará y almacenará cada una de los datos ingresados
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nIngrese la cantidad de agua caída en el día número [{0}]", i + 1);
                Console.Write("Agua caída (mmilímetros) -> ");
                aguaCaida[i] = Convert.ToDouble(Console.ReadLine());

            }

            //Creo y defino variables para realizar las operaciones requeridas
            double mayorCantidadLluvia = 0, menorCantidadLluvia = 0, promedio = 0, mayorDiaLluvia = 0, menorDiaLluvia = 0;
            mayorCantidadLluvia = aguaCaida[0];
            menorCantidadLluvia = aguaCaida[0];
            int diaMes = 0;

            //Ciclo que revisa cuál de todos los datos ingresados es el mayor y el menor
            for (int i = 0; i < 30; i++)
            {
                diaMes = i + 1;

                if (aguaCaida[i] >= mayorCantidadLluvia)
                {
                    mayorCantidadLluvia = aguaCaida[i];
                    mayorDiaLluvia = diaMes;
                }
                if (aguaCaida[i] <= menorCantidadLluvia)
                {
                    menorCantidadLluvia = aguaCaida[i];
                    menorDiaLluvia = diaMes;
                }
            }

            //Ciclo que halla el promedio de la cantidad de lluvia durante los 30 días
            for (int i = 0; i < 30; i++)
            {
                promedio = promedio + aguaCaida[i];
            }
            promedio = (promedio / 30);

            //Mensajes de salida que imprimen los datos ya procesados
            Console.WriteLine("\n\n===============================================================================");
            Console.WriteLine("El día con mayor cantidad de lluvia fue el [{0}], con [{1}] mililitros de agua", mayorDiaLluvia, mayorCantidadLluvia);
            Console.WriteLine("El día con menor cantidad de lluvia fue el [{0}], con [{1}] mililitros de agua", menorDiaLluvia, menorCantidadLluvia);
            Console.WriteLine("El promedio de lluvia de los 30 días es de [{0}] mililitros de agua", promedio);
            Console.WriteLine("===============================================================================");
            Console.ReadKey();
        }
    }
}
