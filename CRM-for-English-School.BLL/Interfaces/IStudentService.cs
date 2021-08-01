using CRM_for_English_School.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Interfaces
{
   public interface IStudentService
    {
        void AddStudent(StudentDataTransferObject person);
        void EditStudent(StudentDataTransferObject person);
        void DeleteStudent(int id);
        StudentDataTransferObject GetStudent(int id);
        IEnumerable<StudentDataTransferObject> GetStudents();
        void Dispose();
    }
}
