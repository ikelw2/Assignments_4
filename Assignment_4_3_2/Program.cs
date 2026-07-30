using Spectre.Console;
using SpectrePreloadedNamespace;

SpectrePreloaded.StartupPanel("SA_4_3_2", "Count frequency of elements in array using dictionary");
//Console.WriteLine("SA_4_3_2 : Count frequency of elements in array using dictionary");
//SpectrePreloaded.HighlightMethod("Method 1", "tbd", 1);
// -------------------------------------------------------------------------------------
// 2.Write a program in C# Sharp to count the frequency of each element of an array.
// 
// Test Data:
// Input the number of elements to be stored in the array :3
// 
// Input 3 elements in the array :
// element - 0 : 25
// element - 1 : 12
// element - 2 : 43
// 
// Expected Output :
// Frequency of all elements of array :
// 25 occurs 1 times
// 12 occurs 1 times
// 43 occurs 1 times

while (true)
{
    // simply define an array, poss generate randomly later
    int[] testArray = [25, 12, 3, 12, 34, 43, 3];
    
    // show what the testArray starts out as
    //Console.WriteLine($"\nsample testArray is [{string.Join(", ", testArray)}]\n");
    // 
    // 
    ////// method 1 use for loop, go through EACH element of array
    //Dictionary<int, int> s = new(); // s is my solutionDictionary
    //for (int i = 0; i < testArray.Length; i++)
    //{
    //    // if dictionary element already exists, add a number to the tally
    //    if (s.TryGetValue(testArray[i], out int val))
    //    {
    //        s[testArray[i]] = (val+1);
    //        //Console.WriteLine($" _ {testArray[i]}+1");
    //    }
    //    // if dictionary element doesn't exist, create an entry and set tally to 1
    //    else
    //    {
    //        s.Add(testArray[i], 1);
    //        //Console.WriteLine($" {testArray[i]}=1");
    //    }
    //}
    //// print output showing frequency of all the elements
    //Console.WriteLine("Frequency of all the elements:");
    //foreach (KeyValuePair<int, int> kvp in s)
    //{
    //    if (kvp.Value > 1)
    //    {
    //        AnsiConsole.MarkupLine($" {kvp.Key.ToString()} occurs [green]{kvp.Value.ToString()}[/] Times");
    //    }
    //    else
    //    {
    //        Console.WriteLine($" {kvp.Key.ToString()} occurs {kvp.Value.ToString()} Times");
    //    }
    //}
    //Console.ReadLine();
    //Console.WriteLine("-----------------------");
    // show what the testArray starts out as
    Console.WriteLine($"\nsample testArray is [{string.Join(", ", testArray)}]\n");


    //// method 2 use foreach loop
    Dictionary<int, int> t = new(); // t is my secondary solution dictionary
    foreach (int i in testArray)
    {
        // if dictionary element already exists, add a number to the tally
        if (t.TryGetValue(i, out int val))
        {
            t[i] = (val + 1);
            //Console.WriteLine($" _ {i}+1");
        }
        // if dictionary element doesn't exist, create an entry and set tally to 1
        else
        {
            t.Add(i, 1);
            //Console.WriteLine($" {i}=1");
        }
    }

    // print output showing frequency of all the elements
    Console.WriteLine("Frequency of all the elements:");
    foreach (KeyValuePair<int, int> kvp in t)
    {
        if (kvp.Value > 1)
        {
            AnsiConsole.MarkupLine($" {kvp.Key.ToString()} occurs [green]{kvp.Value.ToString()}[/] Times");
        }
        else
        {
            Console.WriteLine($" {kvp.Key.ToString()} occurs {kvp.Value.ToString()} Times");
        }
    }









    if (SpectrePreloaded.AskUserToContinue() == false) { break; }
}
SpectrePreloaded.ShutdownTasks(doReadline: false, doClear: false);