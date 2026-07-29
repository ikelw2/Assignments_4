using Assignment_4_2.Views;

namespace Assignment_4_2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    //--------------------------------
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();


        // step 1, show Login form
        bool authSuccess = false;
        bool attemptedLogin = true;
        using (LoginForm loginForm = new LoginForm())
        {
            // save result after login form closes
            DialogResult result = loginForm.ShowDialog();

            // if user closed form by clicking 'Login' // see LoginForm.cs for this
            if (result == DialogResult.OK)
            {
                // save authSuccess locally from loginForm.AuthenticationReesult
                authSuccess = loginForm.AuthenticationResult;
                attemptedLogin = true;
            }
            else
            {
                attemptedLogin = false;
            }
        } // loginForm is automatically destroyed here


        // step 2, if authSuccess, run the StudentDetailsForm
        if (authSuccess)
        {
            //MessageBox.Show("---authSuccess"); // useful debug feature
            Application.Run(new StudentDetailsForm());
        }
        else
        {
            if (attemptedLogin)
            {
                MessageBox.Show("Authentication Failed.");
                // simply close app if user auth failed
            }
        }
    }
    //--------------------------------
}