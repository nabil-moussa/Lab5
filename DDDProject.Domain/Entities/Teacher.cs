namespace DDDProject.Domain;

public class Teacher:User
{
    public List<Course> Courses { get; set; } = new List<Course>();
}