public class Car
{
    public string Id { get; set; }
    public string Model { get; set; }
    public CarCondition Condition { get; set; }
    public CarStatus Status { get; set; }

    public Car(string id, string model, CarCondition condition, CarStatus status)
    {
        Id = id;
        Model = model;
        Condition = condition;
        Status = status;
    }

    public bool IsAvailable()
    {
        return Status == CarStatus.Available;
    }
}