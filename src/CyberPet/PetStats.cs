using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class PetStats
    {
        public static PetCharacter myPet = new PetCharacter();
        public string name;
        public int energy = 10;
        public int hunger = 0;
        public int happy = 6;

        public void PetStatistics()
        {
            if (energy <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Energy: " + energy);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Energy: " + energy);
                Console.ResetColor();
            }

            if (hunger >= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hunger: " + hunger);
                Console.ResetColor();
            }
            else if (hunger == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hunger: " + hunger);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hunger: " + hunger);
                Console.ResetColor();
            }

            if (happy == 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Happiness: " + happy);
                Console.ResetColor();
            }
            else if (happy <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Happiness: " + happy);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Happiness: " + happy);
                Console.ResetColor();
            }
        }
    }
}
