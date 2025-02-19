namespace DDDProject.Domain;

public class Student:User
{
    public decimal GradeAverage { get; set; }
    public bool CanApplyToFrance { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}