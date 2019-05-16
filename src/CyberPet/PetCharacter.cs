using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class PetCharacter
    {
        public string name;
        public int energy = 10;
        public int hunger = 0;
        public int happy = 6;


        public void Feed()
        {
            if (hunger == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " is not hungry right now");
                Console.ResetColor();
            }
            else if (hunger <= 9)
            {
                hunger -= 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " has been fed, hunger is now " + hunger);
                Console.ResetColor();
            }

        }

        public void Play()
        {
            if (energy == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " is too tired to play right now.");
                Console.ResetColor();
            }
            else if (happy == 10)
            {
                energy -= 2;
                hunger += 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " is as happy as can be!");
                Console.ResetColor();
            }
            else if (hunger == 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " is too hungry to play right now!");
                Console.ResetColor();
            }
            else
            {
                energy -= 2;
                hunger += 2;
                happy += 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " had a great time playing with you.");
                Console.ResetColor();
            }
        }

        public void Sleep()
        {
            if (energy == 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " is not tired right now");
                Console.ResetColor();
            }
            else
            {
                energy = 10;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + " had a great sleep and is ready to play some more");
                Console.ResetColor();
            }
        }



    }
}
