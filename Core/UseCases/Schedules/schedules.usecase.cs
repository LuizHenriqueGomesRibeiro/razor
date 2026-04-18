using razor.Core.Repositories.Schedules;

namespace razor.Core.UseCases.schedules {

  public class SchedulesUseCase
  {
    private readonly SchedulesRepository _schedules;
    public SchedulesUseCase(SchedulesRepository schedules)
    {
      _schedules = schedules;
    }

    public async Task<List<Schedule>> GetSchedules()
    {
      List<Schedule> sc = await _schedules.GetSchedules();
      return sc;
    }
  }
}