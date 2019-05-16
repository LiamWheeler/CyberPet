using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class Dog : IPet
    {
        public string Name { get; set; }
        public int energy { get; set; }
        public int hunger { get; set; }
        public int happy { get; set; }

        public Dog() {
            energy = 10;
            hunger =0;
            happy = 4;
        }

        public void Feed()
        {
            if (hunger == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " is not hungry right now");
                Console.ResetColor();
            }
            else if (hunger <= 9)
            {
                hunger -= 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " has been fed, hunger is now " + hunger);
                Console.ResetColor();
            }

        }

        public void Play()
        {
            if (energy == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " is too tired to play right now.");
                Console.ResetColor();
            }
            else if (happy == 10)
            {
                energy -= 2;
                hunger += 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " is as happy as can be!");
                Console.ResetColor();
            }
            else if (hunger == 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " is too hungry to play right now!");
                Console.ResetColor();
            }
            else
            {
                energy -= 2;
                hunger += 2;
                happy += 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " had a great time playing with you.");
                Console.ResetColor();
            }
        }

        public void Sleep()
        {
            if (energy == 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " is not tired right now");
                Console.ResetColor();
            }
            else
            {
                energy = 10;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " had a great sleep and is ready to play some more");
                Console.ResetColor();
            }
        }



    }
}
