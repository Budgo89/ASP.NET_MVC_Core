namespace Lesson8.ViewModels;
public class ScheduleViewModels
{
    public int Id { get; set; }
    public string DayOfTheWeek { get; set; } = null!;
    public string BeginningWork { get; set; } = null!;
    public string EndWork { get; set; }
}
