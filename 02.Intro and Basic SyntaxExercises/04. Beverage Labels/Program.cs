using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volumeMl = int.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarsContent = double.Parse(Console.ReadLine());

            var energy = volumeMl * energyContent / 100;
            var sugar = volumeMl * sugarsContent / 100; 

            Console.WriteLine($"{volumeMl}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
