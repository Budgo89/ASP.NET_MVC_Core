using Lesson8.Models;
using Lesson8.Services.Interfaces;

namespace Lesson8.Services;

public class InMemoryScheduleStore : IScheduleStore
{
    private readonly ILogger<InMemoryScheduleStore> _logger;
    private readonly List<Schedule> _schedules;

    public InMemoryScheduleStore(ILogger<InMemoryScheduleStore> logger)
    {
        _logger = logger;
        _schedules = new()
        {
            new Schedule(1, "Понедельник", "10.00", "20.00"),
            new Schedule(2, "Вторник", "09.00", "19.00"),
            new Schedule(3, "Среда", "08.00", "21.00"),
            new Schedule(4, "Четверг", "12.00", "18.00"),
            new Schedule(5, "Тяпница", "08.00", "15.00"),
            new Schedule(6, "Суббота", "--", "--"),
            new Schedule(7, "Воскресенье", "--", "--"),
        };
    }

    public bool Edit(Schedule item)
    {
        var db_item = GetById(item.Id);
        if (db_item is null)
            return false;
        db_item.BeginningWork = item.BeginningWork;
        db_item.DayOfTheWeek = item.DayOfTheWeek;
        db_item.EndWork = item.EndWork;

        return true;
    }

    public IEnumerable<Schedule> GetAll() => _schedules;

    public Schedule? GetById(int id) => _schedules.FirstOrDefault(item => item.Id == id);
}
