using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int choice = 0;
            choice = p.GetChoice();
            //Console.WriteLine(choice); 
            
            while (choice !=0)  //Loop and continue to let user choose an option until they enter 0 to end.
            {
                switch (choice)
                {
                    case 1:
                        p.Option1();
                        break;

                    case 2:
                        p.Option2();
                        break;
                    case 3:
                        string s = p.Option3();
                        Console.WriteLine($"Random dinosaur from above: {s}");
                        break;
                    case 0:             // End while loop
                        break;
                } 
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

         void Option1()
        {
            Random r = new Random();
            int x = r.Next(1,10);  //Generate the random number
            Console.WriteLine($"Random number: {x}");
        }

        void Option2()
        {
            DateTime date = DateTime.Today; //Create a DateTime object and assign it today's date
            Console.WriteLine(date.ToShortDateString());  // Print it in the format DD/MM/YYYY
        }
        
        string Option3 ()
        {
            string s = "";
            Random ranName = new Random();
            string [] list = 
                { "T-Rex", "Triceratops", "Velociraptor", "Stegosaurus", "Spinosaurus", "Archaeopteryx", 
                "Brachiosaurus", "Allosaurus",  "Apatosaurus", "Dilophosaurus"};
            
            var sort = list.OrderByDescending(x => x);
            Console.WriteLine("List in descending order");
            foreach (string name in sort)
                Console.WriteLine(name);
            int x = ranName.Next(9);
            s = list[x];
            return s;
        }
    }

}

