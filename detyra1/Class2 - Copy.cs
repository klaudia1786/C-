using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    internal class Class2
    {
        static void Main(string[] args){

            Console.WriteLine("Shkruaj 2 numra");
        int a= Convert.ToInt32(Console.ReadLine());
        int b= Convert.ToInt32(Console.ReadLine());
            double modulo = Convert.ToDouble(a % b);


           Console.WriteLine("Mbetja eshte: "+modulo);

            Console.ReadLine();


            Console.WriteLine("Shkruaj 5 numra");

            int nr1, nr2, nr3, nr4, nr5;
            nr1= Convert.ToInt32(Console.ReadLine());
            nr2 = Convert.ToInt32(Console.ReadLine());
            nr3 = Convert.ToInt32(Console.ReadLine());
            nr4 = Convert.ToInt32(Console.ReadLine());
            nr5 = Convert.ToInt32(Console.ReadLine());
            int sum = (nr1 + nr2 + nr3 + nr4 + nr5);
            double average = Convert.ToDouble(sum)/5;

            Console.WriteLine("The sum of given numbers is: " + sum + " and the average is:" + average);
            Console.ReadLine();


            int x = -10 + (7 * 5);
            double y =((25+4)%9)*1.0;
            double z = (10 + (-3*4)/9)*1.0;
            double m = (1 + (23 / 3) * 2 - 7 % 3)*1.0;

            Console.WriteLine("-10 + (7 * 5)=" +x);
            Console.WriteLine("(25+4)%9=" + y);
            Console.WriteLine("10+(-3*4)/9=" + z);
            Console.WriteLine("1 + (23 / 3) * 2 - 7 % 3=" + m);


        }
    }
}
