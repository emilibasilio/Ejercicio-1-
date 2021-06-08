using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_Vec_Basilioo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];

            for(int i=0; i<=9; i++)
            {
                Console.WriteLine("i: " + i);
                Console.Write("Ingrese una letra: ");
                dato[i] = char.Parse(Console.ReadLine());
                
            }

            Console.ReadKey();


        }
    }
}
