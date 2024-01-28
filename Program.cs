using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); // Creating a Random object inside Main

        while (true)
        {
            // Menu of features for steps 2-5
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Output a random integer between 1-10");
            Console.WriteLine("2) Show today's date");
            Console.WriteLine("3) Output a random dinosaur name");
            Console.WriteLine("4) Input a string, then perform a random action on that string");
            Console.WriteLine("Enter your choice (1-4): ");

            // Accepting user input
            string userInput = Console.ReadLine();

            // Validating and processing user input
            if (int.TryParse(userInput, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose Option 1.");
                        // Creating a random number generator
                        int randomNumber = random.Next(1, 11);

                        // Outputting the random number to the console
                        Console.WriteLine("Here is your random number: " + randomNumber);
                        break;

                    case 2:
                        Console.WriteLine("You chose Option 2.");
                        // Getting today's date
                        DateTime today = DateTime.Today;

                        // Converting today's date to Short Date String format
                        string shortDateString = today.ToShortDateString();

                        // Printing today's date in Short Date String format
                        Console.WriteLine("Today's date (Short Date String format): " + shortDateString);
                        break;

                    case 3:
                        Console.WriteLine("You chose Option 3.");
                        // Creating a list of dinosaur names
                        List<string> dinosaurNames = new List<string>
                        {
                            "Tyrannosaurus",
                            "Triceratops",
                            "Stegosaurus",
                            "Velociraptor",
                            "Brachiosaurus",
                            "Allosaurus",
                            "Ankylosaurus",
                            "Pterodactyl",
                            "Diplodocus",
                            "Spinosaurus"
                        };

                        // Ordering the list alphabetically using LINQ
                        dinosaurNames = dinosaurNames.OrderBy(name => name).ToList();

                        // Generating a random index to select a dinosaur name
                        int randomIndex = random.Next(0, dinosaurNames.Count);

                        // Outputting a random dinosaur name from the list
                        string randomDinosaurName = dinosaurNames[randomIndex];
                        Console.WriteLine("Random dinosaur name: " + randomDinosaurName);
                        break;

                    case 4:
                        Console.WriteLine("You chose Option 4.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                // If user inputs anything else
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Asking if the user wants to continue or not
            Console.WriteLine("Do you want to continue? (Y/N)");
            string continueChoice = Console.ReadLine().Trim().ToUpper();
            if (continueChoice != "Y")
                break;
        }
    }
}
