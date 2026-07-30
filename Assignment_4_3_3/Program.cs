using Spectre.Console;
using SpectrePreloadedNamespace;

// 3.Write a program in C# Sharp to print all unique elements in an array.
// 
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 1
// element - 1 : 5
// element - 2 : 1
//
// Expected Output :
// The unique elements found in the array are : 5

SpectrePreloaded.StartupPanel("SA_4_3_3", "print all unique elements in array");
//Console.WriteLine("SA_4_3_3 print all unique elements in array");
//SpectrePreloaded.HighlightMethod("Method 1", "tbd", 1);
while (true)
{
    int[] testArray = [25, 12, 3, 12, 34, 43, 3]; // unique are 25, 34 and 43
    Console.WriteLine($"sample testArray is [{string.Join(", ", testArray)}]\n");

    Dictionary<int, int> d = new();

    // so, we want to print only the unique singular values,
    // that don't appear in an array more than once...
    //
    // again first trying to use dictionary here...

    foreach ( int i in testArray )
    {
        // if dictionary element already exists, add a number to the tally
        if (d.TryGetValue(i, out int val))
        {
            d[i] = (val + 1);
            //Console.WriteLine($" _ {i}+1");
        }
        // if dictionary element doesn't exist, create an entry and set tally to 1
        else
        {
            d.Add(i, 1);
            //Console.WriteLine($" {i}=1");
        }
    }


    // print output showing frequency of all the elements
    Console.WriteLine("The unique elements found in the array are --");
    foreach (KeyValuePair<int, int> kvp in d)
    {
        if (kvp.Value == 1)
            Console.WriteLine(kvp.Key.ToString());
        //{
        //    AnsiConsole.MarkupLine($" {kvp.Key.ToString()} occurs [green]{kvp.Value.ToString()}[/] time");
        //}
        //else
        //{
        //    Console.WriteLine($" {kvp.Key.ToString()} occurs {kvp.Value.ToString()} times");
        //}
    }

    Console.ReadLine();
    Console.WriteLine("-----------------------------------");
    /////////////////////////////////////////////////////////////////////////
    ///
    //
    //  AI ANSWERS included below for my own learning purposes, to see how
    //  to use LINQ and other methods to accomplish the same goal...
    //
    ///
    /////////////////////////////////////////////////////////////////////////
    // AI provided answer: 
    //
    // For execution speed O(N) time complexity:
    // Use a Dictionary<int, int> or HashSet<int> to count frequencies.
    //
    // For code readability one-line solution:
    // Use LINQ (Language Integrated Query) to group and filter the array.
    //

    int[] a = [1, 1, 2, 3, 3, 4]; // unique are 2 and 4
    Console.WriteLine($"\nsample array a is [{string.Join(", ", a)}],   // unique are 2 and 4 \n");
    d.Clear(); // reset dictionary 

    // Method 1: use LINQ --------------------------------------------------
    //    step a. Group, filter for count == 1, and select the key
    var uniqueSingular = a.GroupBy(x => x)             // c. group by entry, or GroupBy creates another array?
                          .Where(g => g.Count() == 1)  // b. limit to where count of element is only 1
                          .Select(g => g.Key);         // a. select Key values...
    //    step b. Print the results
    Console.WriteLine("Method 1: LINQ - Unique singular elements:");
    Console.WriteLine(string.Join(", ", uniqueSingular.Select(x => x.ToString()) )); 
    // I'm trying to use more of the LAMBDA operator so I get used to seeing and using it...
    Console.WriteLine();

    // Method 2: use ? --------------------------------------------------

    //Method 2: Dictionary Frequency Count(Fastest Performance)





















    if (SpectrePreloaded.AskUserToContinue() == false) { break; }
}
SpectrePreloaded.ShutdownTasks(doReadline: false, doClear: false);






