﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    public Student(string firstName, string secondName, int age)
    {
        this.FirstName = firstName;
        this.LastName = secondName;
        this.Age = age;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
}

