﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Attendance
    {
        public Course Course { get; set; }

        [Key]
        [Column(Order =1)]
        public int CourseId { get; set; }
        public int MyProperty { get; set; }
        public AplicationUser Attendee { get; set; }
        [Key]
        [Column(Order =2)]
        public string AttendeeId { get; set; }
    }
}