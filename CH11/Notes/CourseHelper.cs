using System;

namespace CH11
{
    internal class CourseHelper
    {
        internal static bool ValidateCourseCode(string code)
        {
            return code.StartsWith("CS") || code.StartsWith("MATH");
        }
    }
}