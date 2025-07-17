namespace System.Domain;

public class Categories_Earnings
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required User User { get; set; }
}