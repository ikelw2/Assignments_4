using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2.Models;

internal class Teacher : User
{
    public int TeacherId { get; set; }
    public string Address { get; set; }

    public Teacher() { }
    public Teacher(int teacherId, string firstName, string lastName, string address)
    {
        TeacherId = teacherId;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public override bool SetPassword(string pwd) // required override since Student inherits from User
    {
        bool passIsSecureEnough = true;

        if (pwd.Contains(" "))
            return false; // password cannot contain space...?

        // if less than 10 characters
        if (pwd.Length <= 5)
            passIsSecureEnough = false;

        //// if fewer than 3 digits, not secure enough
        //if (pwd.Count(char.IsDigit) <= 3)
        //    passIsSecureEnough = false;

        //// if fewer than 3 lowercase letters, not secure enough
        //if (pwd.Count(char.IsLower) <= 3)
        //    passIsSecureEnough = false;

        //// if fewer than 3 uppercase letters, not secure enough
        //if (pwd.Count(char.IsUpper) <= 3)
        //    passIsSecureEnough = false;

        //// if fewer than 3 punctuation or symbol characters, not secure enough
        //int tallyOfSpecialChars = 0;
        //tallyOfSpecialChars += pwd.Count(char.IsPunctuation);
        //tallyOfSpecialChars += pwd.Count(char.IsSymbol);
        //if (tallyOfSpecialChars <= 3)
        //    passIsSecureEnough = false;

        if (passIsSecureEnough)
        {
            _password = pwd;
            return true; // enough complexity, password set
        }
        else
        {
            return false; // not enough complexity, password not set
        }
    }
}
