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
                Console.WriteLine("30. Dodawanie");
                Console.WriteLine("50. Odejmowanie");
                Console.WriteLine("3. Mnozenie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
            if (menuOption == 0)
                break;
                 }
        }
    }
}
