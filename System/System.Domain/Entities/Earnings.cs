using System.Domain;

public partial class Earnings
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Description { get; set; }
    public required string Color { get; set; }
    public required double Value { get; set; }
    public required Categories_Earnings Category { get; set; }
    public required DateTime Date { get; set; }
    public required User User{ get; set; }
    
}