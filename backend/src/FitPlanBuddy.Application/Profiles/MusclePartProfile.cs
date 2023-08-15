using AutoMapper;
using FitPlanBuddy.Application.Dto.MusclePartDto;
using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Application.Profiles
{
    public class MusclePartProfile : Profile
    {
        public MusclePartProfile()
        {
            CreateMap<MusclePart, MusclePartRead>().ReverseMap();
        }
    }
}
