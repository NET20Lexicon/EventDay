﻿using EventDayWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventDayWeb.Models.DTO
{
    public class LectureDto
    {
        public string Title { get; set; }
        public int Level { get; set; }
        //   public int EventDayId { get; set; }
        [Required]
        public int SpeakerId { get; set; }


        public SpeakerDto Speaker { get; set; }
    }
}
