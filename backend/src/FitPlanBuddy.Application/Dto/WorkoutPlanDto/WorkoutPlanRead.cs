using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Application.Dto.WorkoutPlanDto
{
    public class WorkoutPlanRead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
