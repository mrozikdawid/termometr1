using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj oznaczenie temperatury, K-Kelvin, C-Celsjusz, F-Fahrenheit");
            int numerZnaku = Console.Read();
            char znak = Convert.ToChar(numerZnaku);
            Console.ReadLine();
            Console.WriteLine("Podaj wartość liczbą temperatury");

            double wartoscTemp = Convert.ToDouble(Console.ReadLine());
            if (znak == 'K')
            {
                Console.WriteLine("Temp w C = {0}", wartoscTemp - 273.15);
                Console.WriteLine("Temp w F = {0}", 9 * (wartoscTemp - 273.15) / 5 + 32);
            }
            else if (znak == 'C')
            {
                Console.WriteLine("Temp w K = {0}", wartoscTemp + 273.15);
                Console.WriteLine("Temp w F = {0}", 9 * wartoscTemp / 5 + 32);
            }
            else if (znak == 'F')
            {
                Console.WriteLine("Temp w C = {0}", (wartoscTemp - 32) * 5 / 9);
                Console.WriteLine("Temp w K = {0}", (wartoscTemp + 273.15) * 5 / 9 + 32);

            }
            Console.ReadKey();
        }
    }
}
