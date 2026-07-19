using System;
using System.Runtime.CompilerServices;
using CH11;

namespace Ch11
{
    public class FacultyMember : Employee
    {
        private string name = string.Empty;
        private string department = string.Empty;
        private decimal salary;

        public string Name
        {
            get { return this.name;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The input cannot be empty");
                this.name = value;
            }
        }

        public string Department
        {
            get { return this.department;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The input cannot be empty");
                this.department = value.ToUpper();
            }
        }

        public decimal Salary
        {
            get {return this.salary;}
            set
            {
                if(value < 0m) throw new ArgumentException("Salary has to be positive and non-negative");
                this.salary = value;
            }
        }

        public FacultyMember(string id) : base(id)
        {
        }

        public void DisplayId(string id)
        {
            Console.WriteLine($"Faculty ID: {employeeId}");
        }
    }
}