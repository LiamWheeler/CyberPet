using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class PetStats
    {
        private static IPet myPet;
        

        public PetStats(IPet pet)
        {
            myPet = pet;
        }
        

        public void PetStatistics()
        {


            if (myPet.energy <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Energy: " + myPet.energy);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Energy: " + myPet.energy);
                Console.ResetColor();
            }

            if (myPet.hunger >= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hunger: " + myPet.hunger);
                Console.ResetColor();
            }
            else if (myPet.hunger == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hunger: " + myPet.hunger);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hunger: " + myPet.hunger);
                Console.ResetColor();
            }

            if (myPet.happy == 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Happiness: " + myPet.happy);
                Console.ResetColor();
            }
            else if (myPet.happy <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Happiness: " + myPet.happy);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Happiness: " + myPet.happy);
                Console.ResetColor();
            }
        }
    }
}
