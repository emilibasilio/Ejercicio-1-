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
            char buscar;
            char p = 's';
            int e;


            while (p == 's')
            {
              Console.Clear();
              Console.WriteLine("Que opción desea realizar: \n1. Ingresar valores \n2. Mostrar valores \n3. Buscar valores ");
              e = int.Parse(Console.ReadLine());

                Console.Clear();
                if (e==1)
                {

                 for (int i=0; i<=9; i++)
                 {
                    
                    Console.Write("Ingrese una letra: ");
                    dato[i] = char.Parse(Console.ReadLine());

                        
                 }
                    Console.ReadKey();
                }

               
            
                if (e==2)
                {
                    Console.Clear();
                    for (int x=0; x<=9; x++)
                 {
                      Console.WriteLine(dato[x]);

                 }
                    Console.ReadKey();
                }
                

                else if(e==3)
                {
                    Console.Clear();
                  Console.Write("Ingrese caracter a buscar: ");
                  buscar = char.Parse(Console.ReadLine());

                 for(int z=0; z<=9; z++)
                 {
                     if(dato[z]==buscar)
                     {
                         Console.Write("dato: "+buscar+" encontrado" );
                     }
                 }
                    Console.ReadKey();
                }
                    Console.Clear();
                    Console.WriteLine("Desea Continuar ['s/n']");
                    p = char.Parse(Console.ReadLine());

            }
            Console.ReadKey();


        }
    }
}
