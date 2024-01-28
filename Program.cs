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
            
            while (choice !=0)
            {
                switch (choice)
                {
                    case 1:
                        p.Option1();
                        break;

                    case 2:
                        p.Option2();
                        break;
                    case 0:
                        break;
                } 
                choice = p.GetChoice();
            }
        }

        int GetChoice()
        {
            int x;
            Console.WriteLine("Enter choice:");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

         void Option1()
        {
            Random r = new Random();
            int x = r.Next(9);
            Console.WriteLine($"Random number: {x}");
        }

        void Option2()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine(date.ToShortDateString());
        }
        
    }

}

