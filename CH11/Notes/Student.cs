using System;
using System.Diagnostics.Metrics;

namespace CH11
{
    public class Student
    {
        private string email = string.Empty;
        private double gpa;
        private string name = string.Empty;

        public string Email
        {
            get { return this.email.ToLower();}
            set
            {
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The input cannot be empty");
                else
                {
                    this.email = value.Trim();
                }
            }
        }
        public string Name
        {
            get { return this.name.ToUpper();}
            set
            {
                Console.WriteLine($"Name changed from '{this.name}' to '{value}'");
                if(!string.IsNullOrWhiteSpace(value))
                {
                    name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
                else
                {
                    name = string.Empty;
                }
            }
        }
        public double GPA
        {
            get { return this.gpa;}
            set
            {
                if (value < 0.00 || value > 4.00)
                {
                    throw new ArgumentOutOfRangeException("GPA exception must be between 0 and 4");
                }
                this.gpa = value;
            }
        }
    }
}