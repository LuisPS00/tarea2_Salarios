using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Salarios
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[] empleados = { "Michael", "Luis", "Pedro", "Cristal" };
            float[] salarios = { 120000, 25000, 400000, 356000 };
            float calculo = 0;
            aguinaldo(salarios, empleados);



            Console.ReadKey();

        }



        public static void aguinaldo(float[] calculoaguinaldo, string[] planilla)
        {
            foreach (string s in planilla)

                Console.WriteLine("Nombre de empleado: " + s);

            foreach (float salario in calculoaguinaldo)
                Console.WriteLine("Su salario es: " + salario +
                                      "  y su aguinaldo es: {0} ", salario * 12);










        }


    }
}

