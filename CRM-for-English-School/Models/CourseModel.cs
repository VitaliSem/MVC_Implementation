﻿using CRM_for_English_School.BLL.Entities;
using System;

namespace CRM_for_English_School.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public DateTime ExpectedStartDate { get; set; }
    }
}