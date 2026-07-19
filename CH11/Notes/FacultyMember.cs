using System;
using System.Runtime.CompilerServices;
using CH11;

namespace Ch11
{
    public class FacultyMember : Employee
    {
        public FacultyMember(string id) : base(id)
        {
        }

        public void DisplayId(string id)
        {
            Console.WriteLine($"Faculty ID: {employeeId}");
        }
    }
}