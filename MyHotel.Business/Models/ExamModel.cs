﻿using System;

namespace PlanBetter.Business.Models
{
    public class ExamModel
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string RoomNo { get; set; }
        public string Details { get; set; }

    }
}
