using Assignment_4_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment_4_2.Services;

internal class MockTeacherData
{
    //internal BindingList<Teacher> TeacherBindingList { get; set; } // store Data for use elsewhere in the program
    internal List<Teacher> TeacherList { get; set; }
    public MockTeacherData()
    {
        TeacherList = new List<Teacher>()
        {
            new Teacher { TeacherId = 101, FirstName = "Sarah", LastName = "Conner", Username = "sconner99", Password = "SecurePassword1!", Address = "123 Maple Street, Springfield" },
            new Teacher { TeacherId = 102, FirstName = "James", LastName = "Smith", Username = "jsmith88", Password = "Tr4ch3r#2026", Address = "456 Oak Avenue, Metropolis" },
            new Teacher { TeacherId = 103, FirstName = "Elena", LastName = "Rostova", Username = "erostova", Password = "P@ssword3Three", Address = "789 Pine Road, Gotham" },
            new Teacher { TeacherId = 104, FirstName = "David", LastName = "Kim", Username = "dkim_edu", Password = "MathIsFun%44", Address = "321 Birch Lane, Riverdale" },
            new Teacher { TeacherId = 105, FirstName = "Marcus", LastName = "Vance", Username = "mvance", Password = "Vanc3Str0ng#", Address = "654 Elm Court, Star City" }
        };
        //TeacherBindingList = new BindingList<Student>(TeacherList);
    }
}
