using System.Domain;

public partial class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required DateTime BirthDate { get; set; }

    public ICollection<Expenses> Expenses { get; set; } = [];
    public ICollection<Earnings> Earnings { get; set; } = [];
    public ICollection<Categories_Earnings> Categories_Earnings { get; set; } = [];
    public ICollection<Categories_Expenses> Categories_Expenses { get; set; } = [];

}