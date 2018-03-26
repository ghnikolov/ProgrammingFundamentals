using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHelth = int.Parse(Console.ReadLine());
            var maxHelth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string helth = new string('|', currentHelth) + new string('.', maxHelth - currentHelth);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{helth}|");
            string energy = new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy);
            Console.WriteLine($"Energy: |{energy}|");
        }
    }
}
