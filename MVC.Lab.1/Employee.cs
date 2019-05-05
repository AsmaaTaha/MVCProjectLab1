using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Lab._1
{
    public class Employee
    {
        string Name;
        int age;
        double salary;

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public Employee()
        {
            Name = "";
            Age = 0;
            Salary = 0;
        }
    }
}