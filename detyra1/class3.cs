using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class class3
    {
        static void Main(string[] args)
        {
            //Drejtekendeshi//
            int a, b;
            Console.WriteLine("Inicializo brinjet e drejtekendeshit: ");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);



            int perimetri = 2 * (a + b);
            double siperfaqja = a * b;
            Console.WriteLine("Perimetri i drejtekendeshhit eshte:" + perimetri + " dhe siperfaqja eshte:" + siperfaqja);

            Console.ReadLine();

            //Trekendeshi//
            int nr1, nr2, nr3;
            Console.WriteLine("Shkruaj 3 brinjet e trekendeshit");
            int.TryParse(Console.ReadLine(), out nr1);
            int.TryParse(Console.ReadLine(), out nr2);
            int.TryParse(Console.ReadLine(), out nr3);
            int perimetriTrekendeshit = nr1 + nr2 + nr3;
            double siperfaqjaTrekendeshit = (nr1 * 0.1 * nr2) / 2;
            Console.WriteLine("Permietri: " + perimetriTrekendeshit + "Siperfaqja: " + siperfaqjaTrekendeshit.ToString("N2"));
            Console.ReadLine();

            //Rreth//
            const double PI = 3.14159;
            double rrezja;
            Console.WriteLine("Vendosni rrezen e rrethit:");
            double.TryParse(Console.ReadLine(), out rrezja);
           
            double circlePerimter = 2 * PI * rrezja;
            double circleArea = rrezja * rrezja * PI;

            Console.WriteLine("Permietri i Rrethit eshte:" + circlePerimter + " Siperfaqja:" + circleArea);
            Console.ReadLine();

            //trapez//

            Console.WriteLine("Jep brinjet e trapezit");

            int d, e, f, g,h;

            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jep lartesine e trapezit");
            h = Convert.ToInt32(Console.ReadLine());

            int perimetriTrapezit = d + e + f + g;
            double siperfaqjaTrapezit = (((d + f) * h) / 2) * 1.0;
            Console.WriteLine("Permietri i Trapezit eshte:" + perimetriTrapezit + "dhe siperfaqja eshte:" + siperfaqjaTrapezit);

                Console.ReadLine();



        }
    } }
