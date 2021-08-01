using CRM_for_English_School.BLL.Entities;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentsGroupService
    {
        IEnumerable<StudentsGroup> GetAllGroups();
        StudentsGroup GetStudentsGroup(int id);
        void AddStudentsGroup(StudentsGroup student);
        void EditStudentsGroup(StudentsGroup student);
        void DeleteStudentsGroup(int id);
    }
}
