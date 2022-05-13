using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //args è un array/vettore di stringhe
            //la linea di comando
            //Eseguire con .\test parametri...
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Parametro {0}: {1}", i, args[i]);
            }
            //per provare a fare debug
            int a = 10;
            if (a > 20)
            {
                Console.WriteLine("Maggiore di venti");
            }
            else
            {
                Console.WriteLine("Minore o uguale a 20");
            }
            //le extention per estendere una classe "sealed"
            Console.WriteLine("pippo pluto paperino".WordCount());
            Console.WriteLine("Fine");
        }
    }
}