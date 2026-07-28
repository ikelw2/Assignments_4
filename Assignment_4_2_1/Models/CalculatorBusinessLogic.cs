

namespace Assignment_4_2_1.Models
{
    internal class CalculatorBusinessLogic 
    {
        //MyMath myMath; // had to move this instantiation to inside specific methods for this to work
        //------------------------------
        public CalculatorBusinessLogic()
        {
            //MyMath myMath = new MyMath(); // had to move this instantiation to inside specific methods for this to work
        }
        //------------------------------
        // In the below CalculatorBusinessLogic methods, each operation takes two parameters
        // and returns a string (not double).
        //
        // This is done so that we can more easily assign a string to the resultant textBox.Text
        // field, and it will show errors (e.g., "div/0") directly in the textBox to keep things
        // simplest for the user.
        //
        // Note: This class uses an instance of the interface MyMath to implement the underlying
        // basic mathematical operations involving doubles (not strings). See 'myMath' below.
        //------------------------------
        public string DoSum(double x, double y)
        {
            MyMath myMath = new MyMath(); 
            return myMath.Add(x, y).ToString();
        }
        //------------------------------
        public string DoDifference(double x, double y)
        {
            MyMath myMath = new MyMath();
            return myMath.Subtract(x, y).ToString();
        }
        //------------------------------
        public string DoProduct(double x, double y)
        {
            MyMath myMath = new MyMath();
            return myMath.Multiply(x, y).ToString();
        }
        //------------------------------
        public string DoQuotient(double x, double y)
        {
            if ((y < 0.000000001) && (y > -0.000000001))
            {
                return "div/0"; // return this if 0 - cannot divide by 0
            }
            else
            {
                MyMath myMath = new MyMath();
                return myMath.Divide(x, y).ToString();
            }
        }
        //------------------------------
        public string DoRemainder(double x, double y)
        {
            if ((y < 0.000000001) && (y > -0.000000001))
            {
                return "mod/0"; // return this if 0 - cannot divide by 0
            }
            else
            {
                return (x % y).ToString(); // use % operator, not myMath
            }
        }
        //------------------------------
        public string DoPower(double x, double y)
        {
            return (Math.Pow(x, y)).ToString();
        }
        //------------------------------
        public string DoRoot(double x, double y)
        {
            if ((y > 1.999999998) && (y < 2.000000001)) // only accept y == 2, to keep things simple
            {
                return (Math.Sqrt(x)).ToString(); // use Math.Sqrt method, not myMath
            }
            else
            {
                return "(not 2)"; // print this if not 2
            }
        }
        //------------------------------
    }
}
