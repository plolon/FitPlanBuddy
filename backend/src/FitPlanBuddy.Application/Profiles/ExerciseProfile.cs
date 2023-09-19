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
                .ForMember(dest => dest.MuscleParts, opt => opt.Ignore());

            CreateMap<Exercise, ExerciseWithDataRead>()
                .ForMember(dest => dest.Reps, opt => opt.Ignore())
                .ForMember(dest => dest.Series, opt => opt.Ignore());
        }
    }
}
