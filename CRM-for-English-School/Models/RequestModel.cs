﻿using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Models
{
    public class RequestModel : PersonModel
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public EnglishLevel? CurrentEnglishLevel { get; set; }
    }
}
