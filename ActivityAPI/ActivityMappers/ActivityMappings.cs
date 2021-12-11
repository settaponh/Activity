using ActivityAPI.Models;
using ActivityAPI.Models.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityAPI.ActivityMappers
{
    public class ActivityMappings : Profile
    {
        public ActivityMappings()
        {
            CreateMap<Activity, ActivityDto>().ReverseMap();
        }
    }
}
