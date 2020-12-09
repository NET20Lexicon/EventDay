﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDayWeb.Models.DTO
{
    public class SpeakerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string CompanyUrl { get; set; }
        public string BlogUrl { get; set; }
        public string GitHub { get; set; }

    }
}
