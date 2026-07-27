using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Policy;
using System.Text;

namespace Assignments_4_1.Models;
internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobilePhone { get; set; }
    public string WorkPhone { get; set; }

    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public string SearchName => $"{FirstName} {LastName}".Trim(); // creates GET method; there is no SET

    public Person(string firstName, string lastName, string mobilePhone, string workPhone, string streetAddress,
        string city, string zipcode) // required for mock data upload
    {
        FirstName = firstName;
        LastName = lastName;
        MobilePhone = mobilePhone;
        WorkPhone = workPhone;
        StreetAddress = streetAddress;
        City = city;
        Zipcode = zipcode;
    }
    public Person() // default constructor
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        MobilePhone = string.Empty;
        WorkPhone = string.Empty;
        StreetAddress = string.Empty;
        City = string.Empty;
        Zipcode = string.Empty;
    }
    public override string ToString()
    {
        return SearchName; // string.Concat(LastName, ", ", FirstName);
    }
}
