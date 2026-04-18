using Microsoft.EntityFrameworkCore;

namespace razor.Core.Repositories.Schedules
{
  public class SchedulesRepository(AppDbContext dbContext)
  {
    AppDbContext _dbContext = dbContext;

    public async Task<List<Schedule>> GetSchedules()
    {
      List<Schedule> schedules = await _dbContext.Schedules.ToListAsync();
      return schedules;
    }

    
  }
}