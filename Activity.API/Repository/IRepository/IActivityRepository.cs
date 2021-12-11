using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityAPI.Repository.IRepository
{
    public interface IActivityRepository
    {
        ICollection<ActivityAPI.Models.Activity> GetActivities();

        
    }
}
