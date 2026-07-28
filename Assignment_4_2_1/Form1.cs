
namespace Assignment_4_2_1
{

    public partial class Form1 : Form
    {
        MathClass myMath;
        public Form1()
        {
            InitializeComponent();

            MathClass myMath = new MathClass();
        }
        // ###################################################################

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            // Use the pattern matching syntax to cast the sender safely
            if (sender is TextBox txtOperand1)
            {
                if (myMath.OperandValidated(txtOperand1.Text, out double Op1)) // funny - must use Op1 within this block... 
                {
                    myMath.IsOperand1Valid = true;
                    myMath.Operand1 = Op1;
                }

                if (myMath.IsOperand1Valid)
                {
                    //MessageBox.Show($"Operand1 is '{Operand1.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DoCalculation();
                }
            }
        }
        // ###################################################################
        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            // Use the pattern matching syntax to cast the sender safely
            if (sender is TextBox txtOperand2)
            {
                if (myMath.OperandValidated(txtOperand2.Text, out double Op2))
                {
                    myMath.IsOperand2Valid = true;
                    myMath.Operand2 = Op2;
                }

                if (myMath.IsOperand2Valid)
                {
                    //MessageBox.Show($"Operand2 is '{Operand2.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myMath.DoCalculation();
                }
            }
        }
        // ###################################################################
        private void DoCalculation()
        {
            // confirm that operands 1 and 2 contain enough digits, are valid values
            //if (IsOperand1Empty || IsOperand2Empty) 
            //{
            //    return;
            //}

            if (IsOperand1Valid && IsOperand2Valid)
            {

                // use ternary for brevity, which is equivalent to:
                //// calculate Sum
                // if (chkSum.Checked == true)
                //     txtSum.Text = CalculateSum();
                // else
                //     txtSum.Text = string.Empty;
                // calculate Sum
                txtSum.Text = chkSum.Checked ? Sum(Operand1, Operand2) : string.Empty;

                // calculate difference
                txtDifference.Text = chkDifference.Checked ? Difference(Operand1, Operand2) : string.Empty;

                // calculate product
                txtProduct.Text = chkProduct.Checked ? Product(Operand1, Operand2) : string.Empty;

                // calculate quotient (if divisor is not 0)
                txtQuotient.Text = chkQuotient.Checked ? Quotient(Operand1, Operand2) : string.Empty;

                // calculate remainder (%)
                txtRemainder.Text = chkRemainder.Checked ? Remainder(Operand1, Operand2) : string.Empty;

                // calculate power
                txtPower.Text = chkPower.Checked ? Power(Operand1, Operand2) : string.Empty;

                // calculate root (not sure on existence of errors here)
                txtRoot.Text = chkRoot.Checked ? Root(Operand1, Operand2) : string.Empty;
            }
        }
    }



    public interface ICalculator
    {
        double Sum(double x, double y);
        double Difference(double x, double y);
        double Product(double x, double y);
        double Quotient(double x, double y);
    }




    public class MathClass : ICalculator
    {

        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public bool IsOperand1Valid { get; set; }
        public bool IsOperand2Valid { get; set; }
        ////private bool IsOperand1Empty { get; set; }
        //private bool IsOperand2Empty { get; set; }

        public MathClass()
        {
            IsOperand1Valid = false;
            IsOperand2Valid = false;
        }

        // ###################################################################
        public bool OperandValidated(string textInput, out double output)
        {
            string input = textInput.Trim();
            if (input == "-")
            {
                // The user just started typing a negative number; handle it safely
                output = 0.0;
            }
            else if (double.TryParse(input, out double parsedValue))
            {
                // Success: It is a fully formed positive or negative double
                output = parsedValue;

                //MessageBox.Show($"parsedValue is '{parsedValue.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                output = Convert.ToDouble(parsedValue);

                //MessageBox.Show($"output is '{output.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            // Error: The text is invalid (e.g., "abc")
            output = 0.0;
            return false;
        }
        //== false)
        //{ 

        //}

        ////if (txtOperand1.Text.Length == 0)
        //if (string.IsNullOrWhiteSpace(txtOperand1.Text))
        //{
        //    IsOperand1Empty = true;
        //    //txtOperand1.Text = string.Empty;
        //}
        //else
        //{
        //    IsOperand1Empty = false;
        //    try
        //    {
        //        IsOperand1Valid = true;
        //        //Operand1 = Convert.ToDouble(txtOperand1.Text);
        //        //Operand1 = double.Parse(txtOperand1.Text);
        //        //IsError = double.TryParse(txtOperand1.Text, out double Operand1);
        //        Operand1 = Convert.ToDouble(txtOperand1.Text.Trim());
        //        //Console.WriteLine("operand1 = " + Operand1.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        IsOperand1Valid = false;
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //MessageBox.Show($"Unable to convert '{txtOperand1.Text}' to double.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtOperand1.Text = string.Empty;
        //    }
        // ###################################################################
        public void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            // Use the pattern matching syntax to cast the sender safely
            if (sender is TextBox txtOperand1)
            {
                if (OperandValidated(txtOperand1.Text, out double Op1)) // funny - must use Op1 within this block... 
                {
                    IsOperand1Valid = true;
                    Operand1 = Op1;
                }

                if (IsOperand1Valid)
                {
                    //MessageBox.Show($"Operand1 is '{Operand1.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DoCalculation();
                }
            }
        }
        // ###################################################################
        public void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            // Use the pattern matching syntax to cast the sender safely
            if (sender is TextBox txtOperand2)
            {
                if (OperandValidated(txtOperand2.Text, out double Op2))
                {
                    IsOperand2Valid = true;
                    Operand2 = Op2;
                }

                if (IsOperand2Valid)
                {
                    //MessageBox.Show($"Operand2 is '{Operand2.ToString():2N}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DoCalculation();
                }
                ////if (txtOperand2.Text.Length == 0)
                //if (string.IsNullOrWhiteSpace(txtOperand2.Text))
                //{
                //    IsOperand2Empty = true;
                //    //txtOperand1.Text = string.Empty;
                //}
                //else
                //{
                //    IsOperand2Empty = false;
                //    System.Console.Beep();

                //    try
                //    {
                //        IsOperand2Valid = true;
                //        //Operand2 = Convert.ToDouble(txtOperand2.Text);
                //        //Operand2 = double.Parse(txtOperand2.Text);
                //        //IsError = double.TryParse(txtOperand2.Text, out double Operand2);
                //        Operand2 = Convert.ToDouble(txtOperand2.Text.Trim());
                //        //Console.WriteLine("operand2 = " + Operand2.ToString());
                //    }
                //    catch (Exception ex)
                //    {
                //        IsOperand2Valid = false;
                //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        //MessageBox.Show($"Unable to convert '{txtOperand2.Text}' to double.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        txtOperand2.Text = string.Empty;
                //    }

                //    if (IsOperand2Valid)
                //    { 
                //        DoCalculation();
                //    }
                //}
            }
        }
        // ###################################################################
        public string Sum(double x, double y)
        {
            //System.Console.WriteLine($"Operand1: {x}    Operand2: {y}");
            // to get above debug comment to show, right-click on project, select properties, under Application->general output, select console (as opposed to windows)
            return (x + y).ToString();
        }
        // ###################################################################
        public string Difference(double x, double y)
        {
            return (x - y).ToString();
        }
        // ###################################################################
        public string Product(double x, double y)
        {
            return (x * y).ToString();
        }
        // ###################################################################
        public string Quotient(double x, double y)
        {
            if ((y < 0.000000001) && (y > -0.000000001))
            {
                return "div/0";
            }
            else
            {
                return (x / y).ToString();
            }
        }
        // ###################################################################
        public string Remainder(double x, double y)
        {
            if ((y < 0.000000001) && (y > -0.000000001))
            {
                return "mod/0";
            }
            else
            {
                return (x % y).ToString();
            }
        }
        // ###################################################################
        public string Power(double x, double y)
        {
            return (Math.Pow(x, y)).ToString();
        }
        // ###################################################################
        public string Root(double x, double y)
        {
            if ((y > 1.999999998) && (y < 2.000000001))
            {
                return (Math.Sqrt(x)).ToString();
            }
            else
            {
                return "(not 2)";
            }
        }
        // ###################################################################
    }
}