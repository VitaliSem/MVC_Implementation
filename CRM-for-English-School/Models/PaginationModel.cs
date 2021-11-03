using System.Collections.Generic;

namespace CRM_for_English_School.Models
{
    public class PaginationModel
    {
        public IEnumerable<RequestModel> Requests { get; set; }
        public IEnumerable<StudentModel> Students { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
