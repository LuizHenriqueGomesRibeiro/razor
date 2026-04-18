using Microsoft.AspNetCore.Mvc;
using razor.Core.UseCases.schedules;

public class SchedulesController: Controller {
  SchedulesUseCase _schedulesUseCase;
  public SchedulesController(SchedulesUseCase schedulesUseCase) {
    _schedulesUseCase = schedulesUseCase;
  }

  public async Task<IActionResult> Index()
  {
    List<Schedule> schedules = await _schedulesUseCase.GetSchedules();
    Console.WriteLine($"schedules: {schedules.Count}");
    return View("~/Views/Schedules/Index.cshtml");
  }
}