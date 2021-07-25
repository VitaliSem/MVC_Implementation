using CRM_for_English_School.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Interfaces
{
    interface IStudentService
    {
        void AddPerson(StudentDataTransferObject person);
        void EditPerson(StudentDataTransferObject person);
        void DeletePerson(int id);
        StudentDataTransferObject GetPerson(int id);
        IEnumerable<StudentDataTransferObject> GetPeople();
        void Dispose();
    }
}
