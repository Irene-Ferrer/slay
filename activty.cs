

using Activity2;
using System;

namespace Activity2
{
    public class Names
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public void FullName(string name)
        {
            Console.WriteLine($"{name}: This is your full name...");
        }
    }
}

class Ambot
{
    static void Main(string[] args )
    {
        List<Names> list = new List<Names>();
        while (true)
        {
            Console.WriteLine("Enter new info: [O/D]");

            if (Console.ReadLine() == "D")
            {
                break;
            }

            Names ngan = new Names();

            Console.WriteLine("Enter your first name: ");
            ngan.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            ngan.LastName = Console.ReadLine();

            Console.WriteLine("Enter your middle name: ");
            ngan.MiddleName = Console.ReadLine();

            list.Add(ngan);
            }
        list.ForEach(x => 
        {
            Console.WriteLine(x.FirstName);
            Console.WriteLine(x.LastName);
            Console.WriteLine(x.MiddleName);
            Console.WriteLine("****************************");
        });
    }
}

