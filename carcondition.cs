public class CarCondition
{
    public string Grade { get; set; }
    public string Description { get; set; }

    public CarCondition(string grade, string description)
    {
        Grade = grade;
        Description = description;
    }
}