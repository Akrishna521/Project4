﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }

        public Student(string name, int cls, char section)
        {
            Name = name;
            Class = cls;
            Section = section;
        }
    }
}