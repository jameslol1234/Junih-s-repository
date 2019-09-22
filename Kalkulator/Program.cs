using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
                {
                Console.WriteLine("2. Wyjscie");
                Console.WriteLine("Psie Targi");
                Console.WriteLine("Sprzeadam psa");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Dzielenie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
            if (menuOption == 0)
                break;
                 }
        }
    }
}
