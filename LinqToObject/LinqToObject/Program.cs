using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examples of LINQ to Object");
            Console.WriteLine(new string('-', 30)+"\n");

            QueryToArray();



            Console.ReadKey();
        }

        // LINQ to Array of strings
        static void QueryToArray()
        {
            string[] FootballTeams = { "Real Madrid", "Barcelona", "AC Milan", "Mancester United", "Shirak", "Mancester City"};

            IEnumerable<string> subset = from g in FootballTeams
                                         where g.Contains(" ") && (g.StartsWith("M") || g.StartsWith("R"))
                                         orderby g
                                         select g;
            Console.WriteLine("Result of LINQ to Array\n");
            foreach (string s in subset)
                Console.WriteLine($"Team: {s}");
        }
    }
}
