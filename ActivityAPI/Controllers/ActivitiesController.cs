using ActivityAPI.Models;
using ActivityAPI.Models.Dtos;
using ActivityAPI.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IActivityRepository _activityRepo;
        private readonly IMapper _mapper;
        public ActivitiesController(IActivityRepository activityRepo, IMapper mapper)
        {
            _activityRepo = activityRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetActivitities()
        {
            var activities = await _activityRepo.GetActivities();
            var activityDtos = new List<ActivityDto>();
            foreach(var activity in activities)
            {
                activityDtos.Add(_mapper.Map<ActivityDto>(activity));
            }

            return Ok(activityDtos);
        }

        [HttpGet("activityId:Guid")]
        public async Task<IActionResult> GetActivity(Guid activityId)
        {
            var activity = await _activityRepo.GetActivity(activityId);
            return Ok(_mapper.Map<ActivityDto>(activity));
        }
    }
}
