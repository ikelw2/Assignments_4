namespace Assignment_4_2_1.Models;

internal class MyValidation
{
    public MyValidation() { }

    // I had help from AI to devise this validation sequence. It does the following:
    //
    // step 1. trim whitespace from textInput string
    // step 2. if string is only "-" minus, don't process it yet, pretend it's 0.0, return false
    // step 3. run double.TryParse on the overall string, should work if "-4" and "-4.3" etc, return true
    
    public bool OperandValidated(string input, out double output)
    {
        string s = input.Trim();
        if (s == "-") // user started typing a negative number; handle it safely
        {
            output = 0.0;
            return false;
        }
        else if (double.TryParse(s, out double d)) // if double.TryParse was successful 
        {
            // d is now a valid positive or negative double, assign it to output
            output = d;
            return true;
        }
        // if double.TryParse failed, text is invalid, e.g., "abc" or "`" etc
        output = 0.0;
        return false;
    }
}
