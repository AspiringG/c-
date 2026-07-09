using System;
using System.Dynamic;
using System.IO.Pipelines;
using System.Linq.Expressions;

public class Department
{
    private string departmentName;
    private List<string> staff;
    private int departmentId;

private List<string> staffList;
    
    public List<string> StaffList
    {
        get { return staffList;}
        set
        {
            if(value.Count == 0)
            {
                throw new ArgumentException("The staff List cannot be empty");
            }
            if(value == null)
            {
                throw new ArgumentException("The string cannot be null");
            }
            foreach(string staffName in value)
            {
                if(string.IsNullOrWhiteSpace(staffName))
                {
                    throw new ArgumentException("Staff name cannot be empty");
                }
            }

            staffList = value;
        }
    }


    public void DiplayStaff()
    {
        foreach(string staffName in staffList)
        {
            Console.WriteLine($"{DepartmentName} Staff: \n {staffName}");
        }
    }


    public void AddStaff(List<string> Staff, string facultyName)
    {
        Staff.Add(facultyName);
    }

    public void AddStaff(List<string> Staff)
    {
        Staff.AddRange(Staff);
    }

    public string DepartmentName
    {
        get {return departmentName;}
        set
        {
            if (value is string stringInput)
            {
                departmentName = value;
            }
            else
            {
                throw new ArgumentException("Input string");
            }
        }
    }

    public List<string> Staff
    {
        get {return staff;}
        set
        {
            staff = value;
        }
    }

    public int DepartmentId
    {
        get {return departmentId;}
        set
        {
            departmentId = value;
        }
    }
}