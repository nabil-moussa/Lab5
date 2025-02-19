namespace DDDProject.Domain;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MaxStudents { get; set; }
    public DateTime EnrollmentStartDate { get; set; }
    public DateTime EnrollmentEndDate { get; set; }
    public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}