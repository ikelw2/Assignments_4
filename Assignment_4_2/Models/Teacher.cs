using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2.Models;

internal class Teacher
{
    public string Name { get; set; }
    
    public string Username = "Teacher"; 
    public string Password = "Admin";

    public Teacher( string name ) 
    {
        Name = name;
    }

    public bool verifyIdentity(string username, string password) 
    {
        if (Username != username || Password != password) // need to test this to make sure it works, check for security purposes...
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
