﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Announcement.Responses
{
    public class CreatedAnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
