using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Application.Profiles
{
    public class ExerciseProfile: Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Exercise, ExerciseRead>().ReverseMap();
        }
    }
}
