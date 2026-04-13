public class User {
  public required int Id { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public required string Name { get; set; }
  public required string Surname { get; set; }
  public required int Cep { get; set; }
  public required string Address { get; set; }
  public int Number { get; set; }
  public string? Complement { get; set; }
  public string? Neighborhood { get; set; } 
  public required string City { get; set; }
  public required string State { get; set; }
  public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}