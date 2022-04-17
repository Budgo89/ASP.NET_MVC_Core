using Lesson8.Models;

namespace Lesson8.Services.Interfaces;

public interface IScheduleStore
{
    IEnumerable<Schedule> GetAll();
    Schedule? GetById(int id);

    bool Edit(Schedule item);
}
