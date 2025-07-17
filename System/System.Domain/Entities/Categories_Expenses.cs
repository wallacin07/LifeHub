namespace System.Domain;

public class Categories_Expenses
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required User User{ get; set; }
}