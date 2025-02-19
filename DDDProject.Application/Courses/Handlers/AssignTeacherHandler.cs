using DDDProject.Application.Courses.Commands;
using DDDProject.Persistence.Context;
using MediatR;

namespace DDDProject.Application.Courses.Handlers;

public class AssignTeacherHandler : IRequestHandler<AssignTeacherCommand, bool>
{
    private readonly UniversityDbContext _context;

    public AssignTeacherHandler(UniversityDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(AssignTeacherCommand request, CancellationToken cancellationToken)
    {
        var course = await _context.Courses.FindAsync(request.CourseId);
        var teacher = await _context.Teachers.FindAsync(request.TeacherId);

        if (course == null || teacher == null)
            return false;

        foreach (var timeSlot in request.TimeSlots)
        {
            timeSlot.CourseId = course.Id;
            timeSlot.TeacherId = teacher.Id;
            _context.TimeSlots.Add(timeSlot);
        }

        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}