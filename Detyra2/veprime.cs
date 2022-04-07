using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek
{
    internal class Class1
    {

        static void Main(string[] args)
        {

            
            /*Krijoni nje program i cili tregon nese nje numer i plote i dhene nga perdoruesi eshte tek ose cift. 
             Ne rast se perdoruesi nuk ka vendosur nje numer, te afishohet mesazhi perkates.*/


           Console.WriteLine("Ju lutem vendoni nje numer ");

            string strInput ;
           
            int number;

           if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 == 0)
                {

                    Console.WriteLine("Numri i dhene eshte cift");
                  }
                else
                {
                    Console.WriteLine("Numri i dhene eshte tek");
                }
            }
            else
                Console.WriteLine(" Variabli nuk eshte ne formatin int ");
        }
    }
}
                
