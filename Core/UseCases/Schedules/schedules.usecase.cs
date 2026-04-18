

using Microsoft.EntityFrameworkCore;
using razor.Core.UseCases.dbUseCase;

namespace razor.Core.UseCases.schedules {

  public class SchedulesUseCase : DbUseCase
  {
    public SchedulesUseCase(AppDbContext dbContext) : base(dbContext) {}

    public async Task<List<Schedule>> GetSchedules()
    {
      List<Schedule> schedules = await _dbContext.Schedules.ToListAsync();
      return schedules;
    }
  }
}