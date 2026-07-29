
using Assignment_4_2_1.Models;
using System.Security.Policy;

namespace Assignment_4_2_1;



public partial class Form1 : Form
{
    // This Form1 class contains the main functionality of our calculator App.
    //
    // It has two boolean values to indicate valid values, and two double values for conducting the calculation operations
    // 
    // There are two event handlers for when the Text values in two text boxes have been changed. If both values are
    // validated as doubles, then DoCalculation is called, and the result fields automatically display the output.
    //
    // // keeping these two lines for self-awareness/self-learning.
    //private CalculatorBusinessLogic myCalcBL { get; set; } // apparently I need to instantiate these objects inside the methods 
    //private MyValidation myValidation { get; set; }
    private bool IsOperand1Valid { get; set; }
    private bool IsOperand2Valid { get; set; }
    private double Operand1 { get; set; }
    private double Operand2 { get; set; }
    //------------------------------
    public Form1()
    {
        IsOperand1Valid = false;
        IsOperand2Valid = false;
        Operand1 = 0.0;
        Operand2 = 0.0;
        InitializeComponent();
    }
    //------------------------------
    // replace double event handler with single one that is a
    // multi-origin event handler, so it works with both text boxes.
    // EVENT HANDLER - activates whenever user edits text in TextBox txtOperand1 
    private void txtOperand_TextChanged(object sender, EventArgs e)
    {
        TextBox sendingTextBox = sender as TextBox; // safe casting no matter which textbox sent it
        if (sendingTextBox != null)
        {
            MyValidation myValidation = new MyValidation();
            if (myValidation.OperandValidated(sendingTextBox.Text, out double Opn)) // learning point for me - must use Op1 within this block... 
            {
                // if operand is validated, save it to the Operand1/2 property
                if (sendingTextBox.Name == "txtOperand1")
                {
                    IsOperand1Valid = true;
                    Operand1 = Opn;
                }
                if (sendingTextBox.Name == "txtOperand2")
                {
                    IsOperand2Valid = true;
                    Operand2 = Opn;
                }
            }
            else // if not validated, may be empty
            {
                if (sendingTextBox.Name == "txtOperand1")
                {
                    IsOperand1Valid = false;
                    if (string.IsNullOrWhiteSpace(txtOperand1.Text) || (txtOperand1.Text == "-"))
                    {
                        ClearResults();
                    }
                }
                if (sendingTextBox.Name == "txtOperand2")
                {
                    IsOperand2Valid = false;
                    if (string.IsNullOrWhiteSpace(txtOperand2.Text) || (txtOperand2.Text == "-"))
                    {
                        ClearResults();
                    }
                }
            }

            // only proceed with calculation if both operands are valid
            if (IsOperand2Valid && IsOperand1Valid)
            {
                DoCalculation();
            }
        }
    }
    //------------------------------
    // functionality replaced above by more universal txtOperand_TextChanged method above
    // this code kept here for the sake of showing each EVENT HANDLER CODE Tactics (2) see below comment ***,
    // and also learning point concerning Op1, see below comment **
    private void txtOperand1_TextChanged(object sender, EventArgs e)
    {
        if (sender is TextBox txtOperand1) // ***
        // ^^ Use "pattern matching syntax" to cast the sender safely, or skips block if fails
        {
            MyValidation myValidation = new MyValidation();
            if (myValidation.OperandValidated(txtOperand1.Text, out double Op1)) // **
            // ^^ learning point for me - must use Op1 within this block... 
            { IsOperand1Valid = true; Operand1 = Op1; }
            else
            { IsOperand1Valid = false; if (string.IsNullOrWhiteSpace(txtOperand1.Text) || (txtOperand1.Text == "-")) { ClearResults(); } }

            if (IsOperand2Valid && IsOperand1Valid) { DoCalculation(); }
        }
    }
    //------------------------------
    // functionality replaced above by more universal txtOperand_TextChanged method above
    // this code kept here for the sake of showing each EVENT HANDLER CODE Tactics (2) see below comment ***
    // and also learning point concerning Op1, see below comment **
    private void txtOperand2_TextChanged(object sender, EventArgs e)
    {
        TextBox sendingTextBox = sender as TextBox; // ***
        if (sendingTextBox != null) // ***
        // ^^ attempts to "convert sender to a TextBox" to cast the sender safely, or null if fails
        {
            MyValidation myValidation = new MyValidation();
            if (myValidation.OperandValidated(txtOperand2.Text, out double Op2)) // **
                                                                                 // ^^ learning point for me - must use Op2 within this block... 
            { IsOperand2Valid = true; Operand2 = Op2; }
            else
            { IsOperand2Valid = false; if (string.IsNullOrWhiteSpace(txtOperand2.Text) || (txtOperand2.Text == "-")) { ClearResults(); } }

            if (IsOperand2Valid && IsOperand1Valid) { DoCalculation(); }
        }
    }
    //------------------------------
    private void DoCalculation()
    {
        // If the checkbox associated with a particular function is checked,
        // assign the calculated result to the associated textbox.Text field.
        // Otherwise, assign blank/empty string to the textbox.Text field.

        // Uses CalculatorBusinessLogic class
        CalculatorBusinessLogic myCalcBL = new CalculatorBusinessLogic();

        // (ternary syntax used to keep each on a single line, as concise as poss)
        // result           = expression            ? if true assign this value                 : else assign this value
        txtSum.Text = chkSum.Checked ? myCalcBL.DoSum(Operand1, Operand2) : string.Empty;
        txtDifference.Text = chkDifference.Checked ? myCalcBL.DoDifference(Operand1, Operand2) : string.Empty;
        txtProduct.Text = chkProduct.Checked ? myCalcBL.DoProduct(Operand1, Operand2) : string.Empty;
        txtQuotient.Text = chkQuotient.Checked ? myCalcBL.DoQuotient(Operand1, Operand2) : string.Empty;
        txtRemainder.Text = chkRemainder.Checked ? myCalcBL.DoRemainder(Operand1, Operand2) : string.Empty;
        txtPower.Text = chkPower.Checked ? myCalcBL.DoPower(Operand1, Operand2) : string.Empty;
        txtRoot.Text = chkRoot.Checked ? myCalcBL.DoRoot(Operand1, Operand2) : string.Empty;

        // // Here can ciew Operand1 and Operand2 here with console-output debug technique
        //System.Console.WriteLine($"Operand1: {x}    Operand2: {y}");
        // // to get above debug comment to show properly, right-click on project, 
        // // select properties, under "Application" -> "General" -> "Output type", 
        // // select "Console" (as opposed to windows).
    }
    //------------------------------
    private void ClearResults()
    {
        // clear all results TextBox.Text fields
        txtSum.Text = string.Empty;
        txtDifference.Text = string.Empty;
        txtProduct.Text = string.Empty;
        txtQuotient.Text = string.Empty;
        txtRemainder.Text = string.Empty;
        txtPower.Text = string.Empty;
        txtRoot.Text = string.Empty;
    }
    //------------------------------
    private void results_Click(object sender, MouseEventArgs e)
    {
        TextBox sendingTextBox = sender as TextBox; // safe casting no matter which textbox sent it
        if (sendingTextBox != null)
        {
            // click copies text of textbox to clipboard 
            Clipboard.SetText(sendingTextBox.Text); // DOES NOT WORK PROPERLY YET...
            
            // // Used AI to get the following notification code which I have not yet implemented.
            // // looking to temporarily show a rectangle notifying user that the text has been
            // // copied to the clipboard. Need to research technical details of doing this... tbd
            // 
            // // Close the old notification if it is still fading/disappearing
            //if (activeNotification != null && !activeNotification.IsDisposed)
            //{
            //    activeNotification.Close();
            //}
            //
            //// Create the notification and pass your message + display time (2500ms)
            //NotificationForm toast = new NotificationForm("Copied to clipboard!", 2500);
            //
            //// Display it modelessly over the current form
            //toast.Show(this);
        }
    }
    //------------------------------
}