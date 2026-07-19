using System;

namespace CH11
{
    public class Course
    {
        private string courseCode = string.Empty;
        private int credits;

        public string CourseCode
        {
            get { return this.courseCode;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Input cannot be empty");
                this.courseCode = value;
            }
        }

        public int Credits
        {
            get { return this.credits;}
            set
            {
                if(value < 1 || value > 6)
                this.credits = value;
                else throw new ArgumentException("Value must be between 1 - 6");
            }
        }


    }
}