using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birthplace");
            string bithPlace = Console.ReadLine();
            Console.WriteLine("Enter your profession");
            string profession = Console.ReadLine();
            Console.WriteLine("Your name is:"+name+"/n Your surname is:"+surname+ "/n Your age is:"+age+ "/n Your birthplace is:"+bithPlace+ "/n Your birthplace is:"+bithPlace+"/n");

            Console.ReadLine();
        }
    }
}
