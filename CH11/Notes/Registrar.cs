using System;

namespace CH11
{
    public class Registrar
    {

        // We exposed data of this class, since the functionality should be
        // accessible by the entire system. Changing public methods can have drastic downstream effects/ 
        public void RegisterStudent(string studentId, string courseCode)
        {
            // Implement logic for registering the student for the course id
        }
        public string GenerateTranscript(string studentIt)
        {
            return "Transcript data";
        }


        // we are securing the courseSeats, to ensure that other classes cannot directly modify it.
        private Dictionary<string, int> courseSeats = new Dictionary<string, int>();

        public void AddCourse(string courseCode, int seats)
        {
            courseSeats[courseCode] = seats;
        }
    }
    
}