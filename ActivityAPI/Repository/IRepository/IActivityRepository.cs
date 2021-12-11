using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivityAPI.Models;

namespace ActivityAPI.Repository.IRepository
{
    public interface IActivityRepository
    {
        Task<ICollection<Activity>> GetActivities();

        Task<Activity> GetActivity(Guid activityId);

        
    }
}
