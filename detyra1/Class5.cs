using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libri2
{
    internal class Class5
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Jep Titullin e librit 1");
            string titulli1 = Console.ReadLine();

            Console.WriteLine("Jep emerin e autorit te librit te pare");
            string autoret1 = Console.ReadLine();

            Console.WriteLine("Jep cmimin e librit 1 ");
            double cmimi1;
            double.TryParse(Console.ReadLine(), out cmimi1);

            Console.WriteLine("Jepni sasine qe doni te merrni");
            double sasia1 = Convert.ToDouble(Console.ReadLine());
            double totali1 = cmimi1 * sasia1;


            Console.WriteLine("Jep Titullin e librit 2");
            string titulli2 = Console.ReadLine();

            Console.WriteLine("Jep emerin e autorit te librit dyte");
            string autoret2 = Console.ReadLine();

            Console.WriteLine("Jep cmimin e librit 2 ");
            double cmimi2;
            double.TryParse(Console.ReadLine(), out cmimi2);

            Console.WriteLine("Jepni sasin qe doni te merrni");
            double sasia2 = Convert.ToDouble(Console.ReadLine());
            double totali2 = cmimi2 * sasia2;

            Console.WriteLine("Jep Titujt e librit 3 ");
            string titulli3 = Console.ReadLine();

            Console.WriteLine("Jep emerin e autorit te librit te trete");
            string autoret3 = Console.ReadLine();

            Console.WriteLine("Jep cmimin e librit 3 ");
            double cmimi3;
            double.TryParse(Console.ReadLine(), out cmimi3);

            Console.WriteLine("Jepni sasin qe doni te merrni");
            double sasia3 = Convert.ToDouble(Console.ReadLine());
            double totali3 = cmimi3 * sasia3;

            Console.WriteLine(titulli1 + " " + autoret1 + " " + cmimi1);
            Console.WriteLine(titulli2 + " " + autoret2 + " " + cmimi2);
            Console.WriteLine(titulli3 + " " + autoret3 + " " + cmimi3);


            double totali = totali1 + totali2 + totali3;

            Console.WriteLine("Jepni shumaen e paguar");
            double shuma = Convert.ToDouble(Console.ReadLine());
            double kusuri = shuma - totali;


            System.Console.WriteLine(" shuma e shpenzuar eshte:" + shuma + " kusuri eshte:" + kusuri);


        }
    }
}
