using MediatR;

namespace DDDProject.Application.Courses.Commands;

public class CreateCourseCommand : IRequest<int>
{
    public string Name { get; set; }
    public int MaxStudents { get; set; }
    public DateTime EnrollmentStartDate { get; set; }
    public DateTime EnrollmentEndDate { get; set; }
}