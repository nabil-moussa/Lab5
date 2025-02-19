using DDDProject.Application.Courses.Commands;
using MediatR;
using DDDProject.Domain;
using DDDProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDProject.Application.Courses.Handlers;

public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, int>
{
    private readonly UniversityDbContext _context;

    public CreateCourseHandler(UniversityDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = new Course
        {
            Name = request.Name,
            MaxStudents = request.MaxStudents,
            EnrollmentStartDate = request.EnrollmentStartDate,
            EnrollmentEndDate = request.EnrollmentEndDate
        };

        _context.Courses.Add(course);
        await _context.SaveChangesAsync(cancellationToken);

        return course.Id;
    }
}