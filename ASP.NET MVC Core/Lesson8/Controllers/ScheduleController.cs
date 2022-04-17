using Lesson8.Models;
using Lesson8.Services.Interfaces;
using Lesson8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson8.Controllers;

public class ScheduleController : Controller
{
    private readonly IScheduleStore _scheduleStore;
    private readonly ILogger<HomeController> _logger;
    public ScheduleController(IScheduleStore scheduleStore, ILogger<HomeController> logger)
    {
        _scheduleStore = scheduleStore;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var schedule = _scheduleStore.GetAll();
        return View(schedule);
    }

    public IActionResult Edit(int id)
    {
        var schedule = _scheduleStore.GetById(id);
        if (schedule is null)
            return NotFound();

        return View(new ScheduleViewModels
        {
            Id = schedule.Id,
            DayOfTheWeek = schedule.DayOfTheWeek,
            BeginningWork = schedule.BeginningWork,
            EndWork = schedule.EndWork
        });
    }

    [HttpPost]
    public IActionResult Edit(ScheduleViewModels models)
    {
        var schedule = new Schedule
        (
            models.Id,
            models.DayOfTheWeek,
            models.BeginningWork,
            models.EndWork
        );
        var edit_result = _scheduleStore.Edit(schedule);
        if (!edit_result)
            return NotFound();
        return RedirectToAction("Index");
    }
}