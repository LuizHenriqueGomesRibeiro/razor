public enum DeviceStatus
{
    Analysing = 0,
    Scheduled = 1,
    Cancelled = 2
}

public class Schedule {
  public required int Id { get; set; }
  public required DeviceStatus Status { get; set; }
  public required string TimeSpan { get; set; }
  public required int UserId { get; set; }
  public required int RoomId { get; set; }
  public required User User { get; set; }
  public required Room Room { get; set; }
}