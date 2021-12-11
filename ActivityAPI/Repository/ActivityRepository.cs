using ActivityAPI.Data;
using ActivityAPI.Models;
using ActivityAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityAPI.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly ApplicationDbContext _db;
        public ActivityRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<ICollection<Activity>> GetActivities()
        {
            return await _db.Activities.OrderBy(a => a.Date).ToListAsync();
        }
        public async Task<Activity> GetActivity(Guid activityId)
        {
            return await _db.Activities.FirstOrDefaultAsync(a => a.Id == activityId);
        }

    
    }
}
