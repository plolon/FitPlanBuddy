using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Application.Profiles
{
    public class WorkoutPlanProfile : Profile
    {
        public WorkoutPlanProfile()
        {
            CreateMap<WorkoutPlanRead, WorkoutPlan>().ReverseMap();
            CreateMap<WorkoutPlanWithExercisesRead, WorkoutPlan>().ReverseMap();

            CreateMap<WorkoutPlanSave, WorkoutPlan>();
        }
    }
}
