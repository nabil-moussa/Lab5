namespace DDDProject.Domain;

public class TimeSlot
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int CourseId { get; set; }
    public int TeacherId { get; set; }
}