using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonvertimiValutes
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            const String EURO1 = "\u20AC";
            Console.WriteLine("Jepni shumen e parave ne euro");
            int euro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jepni kursin e kembimit");
            double kursiKembimit;

            double.TryParse(Console.ReadLine(), out kursiKembimit);

            double dollar = euro * kursiKembimit;

            Console.WriteLine(+euro+EURO1+" kembehet me " + dollar + "$");



        }



    }
}
