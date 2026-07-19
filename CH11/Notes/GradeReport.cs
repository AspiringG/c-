using System;

namespace CH11
{
    public class GradeReport
    {
        private double finalGrade = 100;

        public double FinalGrade
        {
            get { return this.finalGrade;}
        }

        private double SetFinalGrade(double finalGrade)
        {
            return this.finalGrade = finalGrade;
        }
    }
}