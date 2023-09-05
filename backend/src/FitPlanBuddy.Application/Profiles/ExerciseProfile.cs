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
            CreateMap<Exercise, ExerciseWithDetailsRead>().ReverseMap();

            CreateMap<ExerciseSave, Exercise>()
                .ForMember(src => src.MuscleParts, opt => opt.Ignore());
        }
    }
}
