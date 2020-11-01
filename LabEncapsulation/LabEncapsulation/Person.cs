using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private const string INVALID_MESS_NAME = "name cannot contain fewer than 3 symbols!";
        private const int MINIMAL_SALARY = 460;

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"First {INVALID_MESS_NAME}");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Last {INVALID_MESS_NAME}");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            { return this.salary; }
            private set
            {
                if (value < MINIMAL_SALARY)
                {
                    throw new ArgumentException($"Salary cannot be less than {MINIMAL_SALARY} leva!");
                }
                this.salary = value;
            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage = percentage / 2;
            }
            this.Salary *= 1 + percentage / 100;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} gets {this.Salary:f2} leva.";
        }
    }
}
