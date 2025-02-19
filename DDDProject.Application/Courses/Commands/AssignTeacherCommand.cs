using DDDProject.Domain;
using MediatR;

namespace DDDProject.Application.Courses.Commands;

public class AssignTeacherCommand : IRequest<bool>
{
    public int CourseId { get; set; }
    public int TeacherId { get; set; }
    public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
}