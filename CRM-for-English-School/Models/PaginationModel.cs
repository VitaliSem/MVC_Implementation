using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_for_English_School.Models
{
    public class PaginationModel
    {
        public IEnumerable<RequestModel> Requests { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
