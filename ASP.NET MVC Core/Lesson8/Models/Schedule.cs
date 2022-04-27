namespace Lesson8.Models;
public class Schedule
{
    public int Id { get; set; }
    public string DayOfTheWeek { get; set; }  = null!;
    public string BeginningWork { get; set; } = null!;
    public string EndWork { get; set; }

    public Schedule(int id, string dayOfTheWeek, string beginningWork, string endWork)
    {
        Id = id;
        DayOfTheWeek = dayOfTheWeek;
        BeginningWork = beginningWork;
        EndWork = endWork;
    }
}
