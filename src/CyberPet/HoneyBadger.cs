using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class HoneyBadger : IPet
    {
        public string Name { get; set; }
        public int energy { get; set; }
        public int hunger { get; set; }
        public int happy  { get; set; }

        public HoneyBadger()
        {
            energy = 10;
            hunger = 0;
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
                Console.WriteLine(Name + " has eaten a jar of honey ,i assume, and seems placated for now, hunger is now " + hunger);
                Console.ResetColor();
            }
        }

        public void Play()
        {
            hunger += 2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name + " ignores your attempts to play with it and does whatever it wants.");
            Console.ResetColor();
        }

        public void Sleep()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name + " bites your arm as you attempt to put it to bed, I would probably get that checked at a hospital.");
            Console.ResetColor();
        }
    }
}
