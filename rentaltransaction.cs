using System.Runtime.ConstrainedExecution;

public class RentalTransaction
{
    public int TransactionId { get; set; }
    public Car Car { get; set; }
    public Customer Customer { get; set; }
    public string RentedDate { get; set; }
    public string DueDate { get; set; }
    public string ReturnDate { get; set; }
    public string Status { get; set; }
    public decimal Fee { get; set; }

    public RentalTransaction(int transactionId, Car car, Customer customer, string rentedDate, string dueDate, string status, decimal fee)
    {
        TransactionId = transactionId;
        Car = car;
        Customer = customer;
        RentedDate = rentedDate;
        DueDate = dueDate;
        ReturnDate = "Not returned yet";
        Status = status;
        Fee = fee;
    }
}