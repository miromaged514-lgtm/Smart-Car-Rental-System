using System;
using System.Collections.Generic;

public class Branch
{
    public string BranchId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string WorkingHours { get; set; }
    public Manager BranchManager { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Car> Cars { get; set; }
    public List<RentalTransaction> Transactions { get; set; }

    public Branch(string branchId, string name, string address, string phone, string workingHours, Manager branchManager)
    {
        BranchId = branchId;
        Name = name;
        Address = address;
        Phone = phone;
        WorkingHours = workingHours;
        BranchManager = branchManager;
        Customers = new List<Customer>();
        Cars = new List<Car>();
        Transactions = new List<RentalTransaction>();
    }

    public void DisplayBranchInfo()
    {
        Console.WriteLine($"Branch ID: {BranchId}");
        Console.WriteLine($"Branch Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Working Hours: {WorkingHours}");
        Console.Write("Manager Info: ");
        BranchManager.DisplayManagerInfo();
        Console.WriteLine($"Total Cars in Fleet: {Cars.Count}");
        Console.WriteLine($"Total Registered Customers: {Customers.Count}");
        Console.WriteLine($"Total Transactions: {Transactions.Count}");
    }

    public void DisplayAllUsers()
    {
        Console.WriteLine("REGISTERED CUSTOMERS:");
        foreach (var customer in Customers)
        {
            Console.WriteLine($"ID: {customer.Id} | Name: {customer.Name} | Phone: {customer.Phone} | Email: {customer.Email} | Joined: {customer.JoinedDate} | Active Rentals: {customer.ActiveRentals}");
        }
    }

    public void DisplayAvailableCars()
    {
        Console.WriteLine("AVAILABLE CARS:");
        foreach (var car in Cars)
        {
            if (car.IsAvailable())
            {
                Console.WriteLine($"ID: {car.Id} | Model: {car.Model} | Condition: {car.Condition.Grade} - {car.Condition.Description} | Status: {car.Status}");
            }
        }
    }

    public void DisplayAllFleet()
    {
        Console.WriteLine("ALL FLEET CARS:");
        foreach (var car in Cars)
        {
            Console.WriteLine($"ID: {car.Id} | Model: {car.Model} | Condition: {car.Condition.Grade} - {car.Condition.Description} | Status: {car.Status}");
        }
    }

    public void RegisterNewCustomer()
    {
        Console.Write("Enter Customer ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Customer Phone: ");
        string phone = Console.ReadLine();
        Console.Write("Enter Customer Email: ");
        string email = Console.ReadLine();

        string joinedDate = DateTime.Now.ToString("dd/MM/yyyy");

        Customers.Add(new Customer(id, name, phone, email, joinedDate, 0));
        Console.WriteLine("Customer registered successfully.");
    }

    public void RentCar()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();
        Customer customer = Customers.Find(c => c.Id == customerId);

        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        Console.Write("Enter Car ID: ");
        string carId = Console.ReadLine();
        Car car = Cars.Find(c => c.Id == carId);

        if (car == null || !car.IsAvailable())
        {
            Console.WriteLine("Car is not available or does not exist.");
            return;
        }

        Console.Write("Enter Transaction ID: ");
        int transId = int.Parse(Console.ReadLine());
        Console.Write("Enter Rental Fee: ");
        decimal fee = decimal.Parse(Console.ReadLine());

        string rentedDate = DateTime.Now.ToString("dd/MM/yyyy");
        string dueDate = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");

        car.Status = CarStatus.Rented;
        customer.ActiveRentals++;

        RentalTransaction transaction = new RentalTransaction(transId, car, customer, rentedDate, dueDate, TransactionStatus.Active.ToString(), fee);
        Transactions.Add(transaction);

        Console.WriteLine("Car rented successfully.");
    }

    public void ReturnCar()
    {
        Console.Write("Enter Transaction ID: ");
        int transId = int.Parse(Console.ReadLine());
        RentalTransaction transaction = Transactions.Find(t => t.TransactionId == transId && t.Status == TransactionStatus.Active.ToString());

        if (transaction == null)
        {
            Console.WriteLine("Active transaction not found.");
            return;
        }

        transaction.Status = TransactionStatus.Completed.ToString();
        transaction.ReturnDate = DateTime.Now.ToString("dd/MM/yyyy");
        transaction.Car.Status = CarStatus.Available;
        transaction.Customer.ActiveRentals--;

        Console.WriteLine("Car returned successfully.");
    }

    public void DisplayCustomerRentalHistory()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();
        Customer customer = Customers.Find(c => c.Id == customerId);

        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        Console.WriteLine($"RENTAL HISTORY FOR {customer.Name}:");
        foreach (var transaction in Transactions)
        {
            if (transaction.Customer.Id == customerId)
            {
                Console.WriteLine($"Trans ID: {transaction.TransactionId} | Car: {transaction.Car.Model} | Rented: {transaction.RentedDate} | Due: {transaction.DueDate} | Return: {transaction.ReturnDate} | Status: {transaction.Status} | Fee: {transaction.Fee:C}");
            }
        }
    }
}