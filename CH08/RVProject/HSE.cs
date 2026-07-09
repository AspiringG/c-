using System;
using System.Diagnostics;

public class HSE : Department
{
    private List<string> hseTasks;
    
    public List<string> HseTasks
    {
        get { return hseTasks;}
        set
        {
            if(value.Count == 0)
            {
                throw new ArgumentException("The hsetask List cannot be empty");
            }
            if(value == null)
            {
                throw new ArgumentException("The string cannot be null");
            }
            foreach(string task in value)
            {
                if(string.IsNullOrWhiteSpace(task))
                {
                    throw new ArgumentException("Task cannot be empty");
                }
            }

            hseTasks = value;
        }
    }


    public void DisplayReport()
    {
        Console.WriteLine("Displayed Report");
    }

    
}