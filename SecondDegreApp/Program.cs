using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDegreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x0, d;

            Console.Write(" Entrez la valeur de a : ");
            a = float.Parse(Console.ReadLine());

            Console.Write(" Entrez la valeur de b : ");
            b = float.Parse(Console.ReadLine());

            Console.Write(" Entrez la valeur de c : ");
            c = float.Parse(Console.ReadLine());

            d = (b * b) - 4 * a * c;
            Console.WriteLine(" Delta d = " + d);

            if (d == 0)
            {
                x0 = x1 = -(b / 2 * a);
                Console.WriteLine(" L'équation a une unique solution : X0 = X1 = " + x0);
                Console.ReadKey();
            } else if (d < 0)
                {
                Console.WriteLine(" L'équation n'a pas de solution réelle ");
                Console.ReadKey();
            }
            else
            {
                d = Math.Sqrt(d);
                x0 = (-b - d) / (2 * a);
                x1 = (-b + d) / (2 * a);
                Console.WriteLine(" L'équation a deux solution distinctes : X1 = "+ x0 + " et X2 = " + x1);
                Console.ReadKey();
            }
        }
    }
}
