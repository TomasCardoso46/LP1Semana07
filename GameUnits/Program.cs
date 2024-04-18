using System;
using GameUnits;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit militaryUnit = new MilitaryUnit(mov: 2, health: 10, attackPower: 5);
            militaryUnit.Move(3);
            Console.WriteLine($"Health: {militaryUnit.Health}, Cost: {militaryUnit.Cost}");
            Console.WriteLine();
            SettlerUnit settlerUnit = new SettlerUnit(attackPower: 1); 
            settlerUnit.Move(2);
            Console.WriteLine($"Health: {settlerUnit.Health}, Cost: {settlerUnit.Cost}");
        }
    }
}

