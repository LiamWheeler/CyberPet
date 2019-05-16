using System;
using System.Linq;

namespace CyberPet
{
    public class Program
    {
        public static IPet myPet;
        public static PetStats petEmotion = new PetStats(myPet);
        private static bool invalidName = true;

        static void Main(string[] args)
        {
            var hasType = false;
            while (!hasType) {
                try
                {

                    Console.WriteLine("Choose your species of cyberpet.(dog/honey badger)");
                    string species = Console.ReadLine();
                    if (species == "dog")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Congratulations on your new dog");
                        myPet = new Dog();
                        PetStats PetEmotion = new PetStats(myPet);
                        Console.ResetColor();
                        hasType = true;
                    }
                    else if (species == "honey badger")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Why would you choose a pet honey badger?");
                        myPet = new HoneyBadger();
                        PetStats PetEmotion = new PetStats(myPet);
                        Console.ResetColor();
                        hasType = true;
                    }
                    else throw new ArgumentException();
                }

                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid input,");
                    Console.ResetColor();
                }
            


            }


            while (invalidName == true)
            {
                try
                {
                    Console.WriteLine("What would you like to name your new cyberpet");
                    string userName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(userName))
                    {
                        myPet.Name = userName.First().ToString().ToUpper() + userName.Substring(1);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Congratulations, your new pet is called " + myPet.Name);
                        Console.ResetColor();
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
                    Console.WriteLine("Feed or Play with " + myPet.Name + " or let them sleep");
                    Console.WriteLine(myPet.Name + "'s stats");
                    petEmotion.PetStatistics();
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(myPet.Name + " has ran away in search of food.");
                        Console.ResetColor();
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
