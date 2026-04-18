using Microsoft.EntityFrameworkCore;
using razor.Core.Data.DataBase;

namespace razor.Core.Repositories.Schedules
{
  public class SchedulesRepository: DbInstance
  {
    public SchedulesRepository(AppDbContext dbContext): base(dbContext, db => 
      {
        db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        db.Database.SetCommandTimeout(60);
      })
    {}

    public async Task<List<Schedule>> GetSchedules()
    {
      List<Schedule> schedules = await _dbInstance.Schedules.ToListAsync();
      return schedules;
    }

    
  }
}