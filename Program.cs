using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int cartaN = 0;
            int total = carta1 + carta2;
            string continuar = "s";
            Console.WriteLine("su primera carta es =" + carta1);
            Console.WriteLine("su segunda carta es =" + carta2);
            Console.WriteLine("Sus puntos son =" + total);
            Console.WriteLine("Desea continuar (s/n)");
            continuar = Console.ReadLine();
            if (continuar == "s")
            {
                while (continuar == "s" && total < 21)
                {
                    cartaN = aleatorio.Next(1, 11);
                    total += cartaN;         

                    if (total > 21)
                    {
                        Console.WriteLine("Perdio");
                        Console.WriteLine("Su nueva carta fue =" + cartaN);
                    }
                    else if(total == 21){
                        Console.WriteLine("gano");
                        Console.WriteLine("Su nueva carta fue =" + cartaN);
                    }
                    else
                    {
                        Console.WriteLine("Su nueva carta es =" + cartaN);
                        
                        Console.WriteLine("Sus puntos son =" + total);
                        Console.WriteLine("Desea continuar (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                Console.WriteLine("Su total fue =" + total);
                Console.WriteLine("Gracias por participár");
            }
            else
            {
                Console.WriteLine("Su total fue =" + total);
                Console.WriteLine("Gracias por participár");
            }
        }
    }
}
