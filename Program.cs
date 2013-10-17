using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace ConsoleApplication4
{

    class Program
    {
        public static void Main()
        {   
            Registro registro = new Registro();
            registro.leer();
            registro.checar();

            Console.ReadLine();

        }
        
        
    }
}