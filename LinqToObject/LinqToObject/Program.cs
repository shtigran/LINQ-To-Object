﻿using System;
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
            VarQuery();


            Console.ReadKey();
        }

        // LINQ to Array of strings by  IEnumerable<>
        static void QueryToArray()
        {
            string[] FootballTeams = { "Real Madrid", "Barcelona", "AC Milan", "Mancester United", "Shirak", "Mancester City"};

            IEnumerable<string> subset = from g in FootballTeams
                                         where g.Contains(" ") && (g.StartsWith("M") || g.StartsWith("R"))
                                         orderby g
                                         select g;
            Console.WriteLine("Result of LINQ to Array by  IEnumerable<>\n");
            foreach (string s in subset)
                Console.WriteLine($"Team: {s}");
        }

        //LINQ to Array by Implicitly Typed Local Variables  
        static void VarQuery()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
            
            var subset = from i in numbers where i%2==0 select i;
            Console.WriteLine("\nResult of LINQ to Array by var\n");
            foreach (var i in subset)
                Console.WriteLine($"Number: {i} ");
        }
    }
}
