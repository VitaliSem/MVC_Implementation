﻿using CRM_for_English_School.AppCore.Enums;
using System;
using System.Collections.Generic;

namespace CRM_for_English_School.AppCore.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public double Price { get; set; }
        public List<Request> Requests { get; set; }
    }
}
