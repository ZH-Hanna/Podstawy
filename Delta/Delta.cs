using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.Write("Podaj wartość parametru a: ");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                    throw new Exception();

                Console.Write("Podaj wartość parametru b: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Podaj wartość parametru c: ");
                c = double.Parse(Console.ReadLine());
                delta = (Math.Pow(b, 2) - 4 * a * c);

                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki :");
                    Console.WriteLine("     x1 =" + " " + x1);
                    Console.WriteLine("     x2 =" + " " + x2);
            }

                else if (delta == 0)
                {
                    x1 = ((-b) / (2 * a));
                    Console.WriteLine("Wyrażenie ma jeden pierwiastek {x1}");
                }
                else if (delta < 0)
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
            }
            catch
            {
                Console.WriteLine("Parametr nie może być = 0 !");
            }
            Console.ReadKey();
        }
    }
}