using CRM_for_English_School.BLL.Entities;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
        void EditStudent(Student student);
        void DeleteStudent(int id);
    }
}
