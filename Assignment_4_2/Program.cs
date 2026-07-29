using Assignment_4_2.Views;

namespace Assignment_4_2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();


        bool authSuccess  = false;
        using (LoginForm loginForm = new LoginForm()) // use LoginForm safely with 'using' statement
        {
            // pauses execution until login form closes
            DialogResult result = loginForm.ShowDialog();

            // check how the user exited the form
            if (result == DialogResult.OK)
            {
                // safely read the value from the form before it is destroyed
                authSuccess = loginForm.AuthenticationResult;
            }
            else
            {
                //MessageBox.Show("Login cancelled by user.");
            }
        } // loginForm is automatically destroyed here


        if (authSuccess)
        {
            //MessageBox.Show("---authSuccess");
            
            // only load data if user successfully logged in 
            Application.Run(new StudentDetailsForm());
        }
        else
        {
            MessageBox.Show("Authentication Failed.");
        }
    }
}