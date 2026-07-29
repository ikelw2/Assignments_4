using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2.Models;

internal class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Month MonthOfAdmission { get; set; }
    public string Address { get; set; }

    public string StudentGPA { get; set; }

    public Student() { }
    public Student(int studentId, string firstName, string lastName, string address, Month monthOfAdmission = Month.January, string studentGPA = "4.0")
    {  
        StudentId = studentId; 
        FirstName = firstName; 
        LastName = lastName; 
        MonthOfAdmission = monthOfAdmission; 
        Address = address;
        StudentGPA = studentGPA;
    }
}
