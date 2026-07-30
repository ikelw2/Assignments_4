using Spectre.Console;
using SpectrePreloadedNamespace;

SpectrePreloaded.StartupPanel("SA_4_3_1", "Calculate electricity bill with ranges");
//Console.WriteLine("SA_4_3_1 Calculate electricity bill with ranges");
//SpectrePreloaded.HighlightMethod("Method 1", "tbd", 1);
while (true)
{
    // Write a program in C# Sharp to calculate and print the Electricity bill
    // of a given customer. The customer id., name and unit consumed by the
    // user should be taken from the keyboard and display the total amount to
    // pay to the customer. The charge are as follows: (you may change the
    // charge sheet values)
    //

    string custId = AnsiConsole.Prompt(new TextPrompt<string>("Please enter your ID number: "));
    string custName = AnsiConsole.Prompt(new TextPrompt<string>("Please enter your Name: "));
    int kwUnits = AnsiConsole.Prompt(new TextPrompt<int>("Please enter total whole kw units used: "));
    int origUnits = kwUnits;


    double t = 0.0; // running Total
    // step 1 handle 2.00 rate for between 600 and more units
    if (kwUnits > 599)
    {
        t += (2.00 * (kwUnits - 599));
        kwUnits = 599;
        AnsiConsole.MarkupLine($"\n[gray]    $2.00 @ >599 subtotal: [/][green]${t:N2}[/]");
    }

    // step 2 handle 1.80 rate for between 400-599 units
    if (kwUnits > 399)
    {
        t += (1.80 * (kwUnits - 399));
        kwUnits = 399;
        AnsiConsole.MarkupLine($"[gray]    $1.80 @ >399 subtotal: [/][green]${t:N2}[/]");
    }

    // step 3 handle 1.50 rate for between 200-399 units
    if (kwUnits > 199)
    {
        t += (1.50 * (kwUnits - 199));
        kwUnits = 199;
        AnsiConsole.MarkupLine($"[gray]    $1.50 @ >199 subtotal: [/][green]${t:N2}[/]");
    }

    // step 4 handle 1.20 rate for between 1-199 units
    if (kwUnits > 0)
    {
        t += (1.20 * (kwUnits - 0));
        kwUnits = 0;
        AnsiConsole.MarkupLine($"[gray]    $1.20 @ >000 subtotal: [/][green]${t:N2}[/]");
    }

    // step 5 if bill over 400$ charge an extra 0.15
    if (t > 400.00)
    {
        t *= 1.15;
        AnsiConsole.MarkupLine($"[gray]    +%15 @ >$400 subtotal: [/][green]${t:N2}[/]\n");
    }

    // display output
    AnsiConsole.MarkupLine($"Cust ID:    {custId}");
    AnsiConsole.MarkupLine($"Cust Name:  {custName}");
    AnsiConsole.MarkupLine($"Units used: {origUnits}");
    AnsiConsole.MarkupLine($"Total Paid: ${t:N2}");




    if (SpectrePreloaded.AskUserToContinue() == false) { break; }
}
SpectrePreloaded.ShutdownTasks(doReadline: false, doClear: false);