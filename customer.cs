public class Customer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string JoinedDate { get; set; }
    public int ActiveRentals { get; set; }

    public Customer(string id, string name, string phone, string email, string joinedDate, int activeRentals)
    {
        Id = id;
        Name = name;
        Phone = phone;
        Email = email;
        JoinedDate = joinedDate;
        ActiveRentals = activeRentals;
    }
}
