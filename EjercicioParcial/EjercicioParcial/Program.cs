using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int dato1 = 16;
                String dato2 = "25g";
                int resultado = dato1 + Convert.ToInt32(dato2);
            }
            catch (Exception)
            {
                Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
            }



            Console.ReadKey();
            //Console.WriteLine(resultado);
        }
    }
}
