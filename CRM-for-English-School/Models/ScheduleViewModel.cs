using System.Collections.Generic;

namespace CRM_for_English_School.Models
{
    public class ScheduleViewModel
    {
        public IEnumerable<LessonModel> Lessons { get; set; }
        public LessonModel Lesson { get; set; }
    }
}
