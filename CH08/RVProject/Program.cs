using System;

    class Program
    {
        static void Main(string[] args)
        {
            RV myRV = new()
            {
                // Assign the data to the object's properties
                VIN = "2Y7C45678M2025RV",
                EngineType = "Gasoline"
            };

            myRV.StartEngine();


            List<string> staffName = ["staff#1", "staff#2", "staff#3"];
            Department IT = new()
            {
                DepartmentName = "IT",
                DepartmentId = 32,
            };

            IT.AddStaff(staffName);
            Department Accounting = new() { DepartmentName = "Accounting/Finance", DepartmentId = 32};
            Department Engineering = new() { DepartmentName = "Engineer/Engineer", DepartmentId = 40};

            HSE hse = new() {DepartmentName = "HSE HealthAndSafetyEnvironment", DepartmentId = 50};
            hse.DisplayReport();
            hse.Staff = new List<string> {"Fuad Mammadli", "Farid Mammadli", "Anar Naghiyev", "Fariz"};
            hse.DiplayStaff();
            

            Console.WriteLine($"Department Name is: {IT.DepartmentId} and the staff: {IT.Staff}");
        }
    }