﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityAPI.Models.Dtos
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
