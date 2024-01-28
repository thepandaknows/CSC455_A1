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
                        // Get string input from the user
                        Console.Write("Enter a string: ");
                        string inputString = Console.ReadLine();

                        // Generate a random number between 1 and 10
                        int randomNumberAction = random.Next(1, 11);

                        // Perform a random action based on the random number
                        switch (randomNumberAction)
                        {
                            case 1:
                                Console.WriteLine($"Length of the string: {inputString.Length}");
                                break;
                            case 2:
                                Console.WriteLine($"Uppercase: {inputString.ToUpper()}");
                                break;
                            case 3:
                                Console.WriteLine($"Lowercase: {inputString.ToLower()}");
                                break;
                            case 4:
                                Console.WriteLine($"Reversed string: {ReverseString(inputString)}");
                                break;
                            case 5:
                                int startIndex = random.Next(inputString.Length);
                                int length = random.Next(inputString.Length - startIndex);
                                Console.WriteLine($"Substring: {inputString.Substring(startIndex, length)}");
                                break;
                            case 6:
                                Console.WriteLine($"Every other letter uppercase: {MakeEveryOtherLetterUppercase(inputString)}");
                                break;
                            case 7:
                                Console.WriteLine($"Convert letters to numbers using ASCII code: {ConvertLettersToNumbers(inputString)}");
                                break;
                            case 8:
                                Console.WriteLine($"Print the string twice: {inputString}{inputString}");
                                break;
                            case 9:
                                Console.WriteLine($"Print the string in alphabetical order: {string.Concat(inputString.OrderBy(c => c))}");
                                break;
                            case 10:
                                Console.WriteLine($"Print the string twice with first iteration reversed: {ReverseString(inputString)}{inputString}");
                                break;
                            default:
                                Console.WriteLine($"No action performed.");
                                break;
                        }
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

    // Method to reverse a string
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Method to make every other letter uppercase
    static string MakeEveryOtherLetterUppercase(string input)
    {
        char[] charArray = input.ToCharArray();
        for (int i = 1; i < charArray.Length; i += 2)
        {
            charArray[i] = char.ToUpper(charArray[i]);
        }
        return new string(charArray);
    }

    // Method to convert letters to numbers using ASCII code
    static string ConvertLettersToNumbers(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                result += (int)c + " ";
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
}
