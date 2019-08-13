using System;

namespace EX_7A___Implementing_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Army:");
            Army FAR327 = new Army(175, "HIMARS", "Rockets") { };
            Console.WriteLine($"Number of people: {FAR327.Personnel}");
            Console.WriteLine($"Type of vehicle: {FAR327.Vehicle}");
            Console.WriteLine($"Type of weapon: {FAR327.Weapon}");

            Console.WriteLine("\nThe Navy:");
            Navy SSPewPew = new Navy(634, "Battle Ship", "Missiles") { };
            Console.WriteLine($"Number of people: {SSPewPew.Personnel}");
            Console.WriteLine($"Type of vehicle: {SSPewPew.Vehicle}");
            Console.WriteLine($"Type of weapon: {SSPewPew.Weapon}");

            Console.WriteLine("\nThe Space Force:");
            SpaceForce USEnterprise = new SpaceForce(321, "Battle Cruiser", "Lazers") { };
            Console.WriteLine($"Number of people: {USEnterprise.Personnel}");
            Console.WriteLine($"Type of vehicle: {USEnterprise.Vehicle}");
            Console.WriteLine($"Type of weapon: {USEnterprise.Weapon}");
        }
    }

    abstract class MilitaryUnit
    {
        internal int Personnel { get; set; }
        internal string Vehicle { get; set; }
        internal string Weapon { get; set; }

    }

    class Army : MilitaryUnit
    {
        public Army(int personnel, string vehicle, string weapon)
        {
            Personnel = personnel;
            Vehicle = vehicle;
            Weapon = weapon;
        }
    }

    class Navy : MilitaryUnit
    {
        public Navy(int personnel, string vehicle, string weapon)
        {
            Personnel = personnel;
            Vehicle = vehicle;
            Weapon = weapon;
        }
    }

    class SpaceForce : MilitaryUnit
    {
        public SpaceForce(int personnel, string vehicle, string weapon)
        {
            Personnel = personnel;
            Vehicle = vehicle;
            Weapon = weapon;
        }
    }


    

}
