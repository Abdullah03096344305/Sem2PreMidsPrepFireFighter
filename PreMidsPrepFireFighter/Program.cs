using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PreMidsPrepFireFighter.BL;
using System.Threading.Tasks;

namespace PreMidsPrepFireFighter
{
    class Program
    {
        static List<FireFighter> firefighters = new List<FireFighter>();
        static List<FireTruck> fireTrucks = new List<FireTruck>();
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to Add a FireFighter");
            Console.WriteLine("Press 2 to Add a Firetruck");
            int option = int.Parse(Console.ReadLine());            
                if (option == 1)
                {
                    Console.WriteLine("Enter FireFighter Name: ");
                    string name = Console.ReadLine();
                    firefighters.Add(new FireFighter(name));
                    Console.WriteLine("FireFighter Name Is " + name);


                }
                else if (option == 2)
                {
                    for (int i = 0; i < firefighters.Count; i++)
                    {
                        Console.WriteLine("FireFighter Name Is " + firefighters[i].GetName());
                    }
                    Console.Write("Choose a firefighter by number: ");
                    int firefighterIndex = int.Parse(Console.ReadLine());
                    firefighterIndex--;
                    if (firefighterIndex >= 0 && firefighterIndex < firefighters.Count)
                    {
                        Console.WriteLine("Fire truck added successfully!");
                        fireTrucks.Add(new FireTruck(new HosePipe("Hard_Plastic", "Ovel", 1.0f, 2.0f), firefighters[firefighterIndex]));
                    }
                }
            
            Console.ReadKey();
        }
    }
}
