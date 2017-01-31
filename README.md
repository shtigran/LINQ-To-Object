# LINQ To Object
# C#6.0  .NET FRAMEWORK 4.6

----
### Purpose

The destination of this project ilustrate the capabilities of LINQ to Object. There are represented different Queries to Object in this project.

----

### LINQ to Object different methods implementations
```C#
// LINQ to Array of strings by  IEnumerable<>
static void QueryToArray()
{
  string[] FootballTeams = { "Real Madrid", "Barcelona", "AC Milan", "Mancester United", "Shirak", "Mancester City" };

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

   var subset = from i in numbers where i % 2 == 0 select i;
                Console.WriteLine("\nResult of LINQ to Array by var\n");
                foreach (var i in subset)
                Console.WriteLine($"Number: {i} ");
  }

//LINQ operations
static void DisplayLINQOperations()
 {
    Console.WriteLine("\nResult of LINQ Operations\n");
    List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
     // Getthe Diff members.
     var carDiff = (from c in myCars select c)
             .Except(from c2 in yourCars select c2);
              Console.WriteLine("Here is what we have in first list, which isn't in second list:");
              foreach (string s in carDiff)
              Console.WriteLine(s);

      // Get the common members.
            var carIntersect = (from c in myCars select c)
            .Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
                Console.WriteLine(s);

       //Get the union of two lists
            var carUnion = (from c in myCars select c)
            .Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s);
        }

 //LINQ with Lambda Expresiion
 static void QueryLambdas()
  {
    string[] currentVideoGames = { "Morrowind", "Uncharted 2","Fallout 3", "Daxter", "System Shock 2"};
       
    var subset = currentVideoGames.Where(game => game.Contains(" "))
            .OrderBy(game => game).Select(game => game);
    Console.WriteLine("\nResult of LINQ tby Lambda Expression");
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }
```
----

### Description of LINQ to Object different methods implementations
This methods implement the basic functionality of LINQ. This methods show working principles of LINQ Queries by IEnumerable<>, Implicitly Typed Local Variables, LINQ operations and Lambda Expresiion.

----

### Program class implementation
```C#
 static void Main(string[] args)
        {
            Console.WriteLine("Examples of LINQ to Object");
            Console.WriteLine(new string('-', 30) + "\n");

            QueryToArray();
            VarQuery();
            DisplayLINQOperations();
            QueryLambdas();

            Console.ReadKey();
        }
```
----

### Description of Program class

Here we invoke the methods.

----

### Test and Result
![N|Solid](https://github.com/shtigran/LINQ-To-Object/blob/master/LINQ.png)

