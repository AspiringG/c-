using System;

public class Safety
{
    private string teamLeaderName;
    private List<string> tasks = new List<string> {"Daddy"};

    public string TeamLeaderName
    {
        get { return teamLeaderName;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Please input text");
            }
            if (int.TryParse(value, out _))
            {
                throw new ArgumentException("Provide a string value, not a number");
            }
            teamLeaderName = value;
        }
    }
    public List<string> Tasks
    {
        get { return tasks;}
        set
        {
            if (value == null) throw new ArgumentException("Please provide string value");
            if (value.Count == 0)
                {
                    throw new ArgumentException("You not leave the field empty");
                }
            foreach(string task in value)
            {
                if (string.IsNullOrWhiteSpace(task))
                {
                    throw new ArgumentException("Task cannot be empty");
                }
            }
            tasks = value;

        }
    }

        
}