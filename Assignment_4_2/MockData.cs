using Assignment_4_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2;

internal class MockData
{
    public List<Student> getData()
    {
        // mock datasource, generated with help from AI, from assignment 3_3
        var data = new List<Student>() {
            new Student(101, "Liam", "Smith", "123 Maple St", Month.January, "3.4"),
            new Student(102, "Noah", "Johnson", "456 Oak Ave", Month.March, "3.3"),
            new Student(103, "Oliver", "Williams", "789 Pine Rd", Month.September, "2.8"),
            new Student(104, "Elijah", "Brown", "321 Cedar Ln", Month.May, "4.0"),
            new Student(105, "James", "Jones", "654 Spruce St", Month.July, "3.8"),
            new Student(106, "Benjamin", "Miller", "987 Birch Blvd", Month.November, "2.6"),
            new Student(107, "Lucas", "Davis", "147 Elm Dr", Month.January, "2.7"),
            new Student(108, "Henry", "Garcia", "258 Willow Ct", Month.September, "3.2"),
            new Student(109, "Alexander", "Rodriguez", "369 Ash Ave", Month.May, "3.1"),
            new Student(110, "Mason", "Wilson", "741 Walnut St", Month.March, "3.9")
            };
        return data;
    }
}
