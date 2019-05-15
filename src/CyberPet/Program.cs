using System;
using System.Linq;

namespace CyberPet
{
    public class Program
    {
        public static PetCharacter myPet = new PetCharacter();
        private static bool invalidName = true;

        static void Main(string[] args)
        {
            while (invalidName == true)
            {
                try
                {
                    Console.WriteLine("What would you like to name your new cyberpet.");
                    string userName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(userName))
                    {
                        myPet.name = userName.First().ToString().ToUpper() + userName.Substring(1);
                        Console.WriteLine("Congratulations, your new pet is called " + myPet.name);
                        invalidName = false;
                    }
                    else throw new ArgumentNullException();
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your cyberpets name cannot be null or whitespace");
                    Console.ResetColor();
                    
                }
            }


            while (true)
            {
                

                


                    Console.WriteLine("Feed or Play with " + myPet.name + " or let them sleep");
                    Console.WriteLine(myPet.name + "'s stats" +"\r\nEnergy: " + myPet.energy
                                    + "\r\nHunger: " + myPet.hunger + "\r\nHappiness: " + myPet.happy);
                    Console.WriteLine("Or press 'q' to quit");
                    var input = Console.ReadLine();

                try
                {     
                    if (input == "q")
                    {
                        break;
                    }
                    else if (myPet.hunger == 10)
                    {
                        Console.WriteLine(myPet.name + " has ran away in search of food");
                        break;
                    }
                    else if (input == "play")
                    {
                        myPet.Play();
                    }
                    else if (input == "feed")
                    {
                        myPet.Feed();

                    }
                    else if (input == "sleep")
                    {
                        myPet.Sleep();
                    }
                    else throw new ArgumentException();
                }



                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unexpected input, try either 'feed', 'play' or 'sleep'.");
                    Console.ResetColor();
                }

            }
                Console.ReadLine();          
        }    
    }
}
