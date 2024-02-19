using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int choice = 0;
            p.Menu();
            choice = p.GetChoice();
            //Console.WriteLine(choice); 
            
            while (choice !=0)  //Loop and continue to let user choose an option until they enter 0 to end.
            {
                switch (choice)
                {
                    case 1:
                        int x = 0;
                         x = p.Option1();
                        Console.WriteLine($"Random number: {x}");
                        break;

                    case 2:
                        p.Option2();
                        break;
                    case 3:
                        string s = p.Option3();
                        Console.WriteLine($"Random dinosaur from above: {s}");
                        break;
                    case 4:
                        string t = p.Option4();
                        Console.WriteLine(t);
                        break;
                    case 0:             // End while loop
                        break;
                    default:
                        break;
                }
                p.Menu();
                choice = p.GetChoice();
            }
        }

          int GetChoice()
        {
            
            int x;
            Console.WriteLine("Enter choice:");
            x = Convert.ToInt32(Console.ReadLine());    //read input from user.
            return x;
        }

         public int Option1()
        {
            Random r = new Random();
            int x = r.Next(1,10);  //Generate the random number
            return x;
        }

        public void Option2()
        {
            DateTime date = DateTime.Today; //Create a DateTime object and assign it today's date
            Console.WriteLine(date.ToShortDateString());  // Print it in the format DD/MM/YYYY
        }

        public string Option3 ()
        {
            string s = "";
            Random ranName = new Random();
            string [] list = 
                { "T-Rex", "Triceratops", "Velociraptor", "Stegosaurus", "Spinosaurus", "Archaeopteryx", 
                "Brachiosaurus", "Allosaurus",  "Apatosaurus", "Dilophosaurus"};
            
            var sort = list.OrderByDescending(x => x);  //Sort list alphabetically in descending order.
            Console.WriteLine("List in descending order");
            foreach (string dino in sort)
                Console.WriteLine(dino);
            int x = ranName.Next(9);
            s = list[x];
            return s;
        }

        public string Option4()
        {
            string s = "Never gonna give you up.";
            //string s = "HELLO"; //Test for case 1.
            int randomFunction = 0;
            Random r = new Random();
            randomFunction = r.Next(9);
            string temp = "";
            //randomFunction = 9;  //variable to test specific cases
            switch (randomFunction)
            {
                case 0:
                    s = s.ToUpper(); //Capitlize all the letters in the string.
                    break;
                case 1:
                    s = s.ToLower(); //Make all the letters in the string to lowercase.
                    break;
                case 2:
                    s = s.Replace("Never", "Always");
                    break;
                case 3:
                    int x = s.Length;
                    s = x.ToString();
                    Console.WriteLine("Length of the string:");
                    break;
                case 4:
                    
                    char[] tempArray= s.ToCharArray();  //Convert string to array.
                    for (int i = s.Length-1; i >= 0; i--)  //For loop to reverse the string.
                    {
                        temp += tempArray[i];
                    }
                    s = temp;  // Assign the reversed string to s.
                    break;
                case 5:
                    int begin = s.IndexOf("Never"); // start string index at Never.
                    temp = "";
                    temp += s.Substring(begin,6);   //print "Never "
                    begin = s.IndexOf("give");      // start string index at give.
                    temp += s.Substring(begin, 5);  //print "give "
                    begin = s.IndexOf("up");        // start string index at up.
                    temp += s.Substring(begin, 3);  //print "up."
                    s = temp.ToString();
                    break;

                case 6:
                    string[] sortSong = { "Never ", "gonna ", "give ", "you ", "up " };  // sort the song in descending order
                    temp = "";
                    var y = sortSong.OrderByDescending(x => x);
                    foreach (string word in y)
                        temp += word;
                    s = temp;
                    break;
                case 7:
                    string[] capSong = { "Never ", "gonna ", "give ", "you ", "up " }; //capitalize every even word
                    for (int i = 0; i<5; i++)
                    {
                        if (i % 2 != 0)
                        {
                            capSong[i] = capSong[i].ToUpper();
                        }
                        temp += capSong[i];
                    }
                    s = temp;
                    break;
                case 8:
                    string[] capSongOdd = { "Never ", "gonna ", "give ", "you ", "up." }; //capitalize every odd word
                    for (int i = 0; i < 5; i++)
                    {
                        if (i % 2 == 0)
                        {
                            capSongOdd[i] = capSongOdd[i].ToUpper();
                        }
                        temp += capSongOdd[i];
                    }
                    s = temp;
                    break;
                case 9:
                    string[] question = { "Never ", "gonna ", "give ", "you ", "up" ,"." }; //Make the song into a question.
                    question[5] = "?";
                    var lastTwo = question.Skip(3);
                    temp = "";
                    foreach (string word in lastTwo)
                    {
                        temp += word;
                    }
                    s = temp;
                    break;
            }
            return s;
        }

        void Menu ()  // Create menu for user.
        {
            Console.WriteLine("\nPlese select an option below:\n");
            Console.WriteLine("1: A random number 1 through 10.\n");
            Console.WriteLine("2: Today's date.\n");
            Console.WriteLine("3: A list of dinosaurs and then a random one chosen.\n");
            Console.WriteLine("4: Randomly change the song lyric \"Never gonna give you up\" by Rick Astley.\n");
            Console.WriteLine("0: To exit.\n");
        }
    }

}

