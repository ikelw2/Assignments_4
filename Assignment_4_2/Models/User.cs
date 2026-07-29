using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_4_2.Models;

internal abstract class User
{
    //-----------------------------
    public string FirstName { get; set; }
    public string LastName { get; set; }


    protected string _zUserId = Guid.NewGuid().ToString(); // gen userid by default
    public string ZUserId { get { return _zUserId; } } // no set function

    public string Username { get; set; }
    protected string _password = Guid.NewGuid().ToString(); // gen password by default
    public string Password 
    {
        set
        {
            if (!SetPassword(value))
            {
                throw new ArgumentException("Password not complex enough", "Invalid Password");
            }
        }
    }
    //-----------------------------
    public abstract bool SetPassword(string pwd);
    //-----------------------------
    public bool VerifyUsernamePassword(string pass, string name)
    {
        // if pass and name match _password and Username
        if ((String.Compare(pass, _password) == 0) && (String.Compare(name, Username) == 0))
        {
            return true; // return true
        }
        return false; // or return false
    }
    //-----------------------------
    public User() { }
    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    //-----------------------------
}