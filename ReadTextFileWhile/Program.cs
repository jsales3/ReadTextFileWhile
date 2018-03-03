using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);

         
            }

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(" ");
            Console.WriteLine("$                    $");
            Console.WriteLine(" ");
            Console.WriteLine("$  jsales3@kent.edu  $");
            Console.WriteLine(" ");
            Console.WriteLine("$                    $");
            Console.WriteLine(" ");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(" ");
            Console.WriteLine("OK, we are done!");

            myReader.Close();
            Console.ReadLine();
        }
    }
}
