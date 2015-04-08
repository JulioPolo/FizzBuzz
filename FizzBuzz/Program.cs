using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "" ;
            int conteo = 0;
            int conteoFizz = 0;
            int conteoBuzz = 0;
            for (int i =1;i<= 1000; i++)
            {
                message = ""; // Convert.ToString(i); ;
                if ((i % 3)  == 0)
                {
                    conteo++;
                    message= "Fizz";
                    conteoFizz++;
                }
                if ((i % 5) == 0)
                {
                    if (message == "Fizz")
                    {
                        conteo++;
                        message = message + "Buzz";
                        conteoBuzz++;
                    }
                    
                }
                
                Console.WriteLine(Convert.ToString(i) + "    " + message);
                
            }
            Console.WriteLine("Número de Fizz = " + conteoFizz.ToString());
            Console.WriteLine("Número de Buzz = " + conteoBuzz.ToString());
            Console.WriteLine("Número de FizzBuzz = " + conteo.ToString());
            Console.WriteLine("Presione una tecla para terminar");
            Console.WriteLine("Develop by Julio Polo");
            Console.WriteLine("Date : {0}", DateTime.Now);
            Console.ReadLine();
        }
    }
}
