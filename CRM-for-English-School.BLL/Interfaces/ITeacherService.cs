using CRM_for_English_School.BLL.Entities;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetTeachers();
        Teacher GetTeacher(int id);
        void AddTeacher(Teacher student);
        void EditTeacher(Teacher student);
        void DeleteTeacher(int id);
    }
}
