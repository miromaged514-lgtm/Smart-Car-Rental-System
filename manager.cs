using System;

public class Manager
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public decimal Salary { get; set; }
    public string HireDate { get; set; }

    public Manager(string id, string name, string phone, decimal salary, string hireDate)
    {
        Id = id;
        Name = name;
        Phone = phone;
        Salary = salary;
        HireDate = hireDate;
    }

    public void DisplayManagerInfo()
    {
        Console.WriteLine($"Manager ID: {Id}, Name: {Name}, Phone: {Phone}, Salary: {Salary:C}, Hire Date: {HireDate}");
    }
}