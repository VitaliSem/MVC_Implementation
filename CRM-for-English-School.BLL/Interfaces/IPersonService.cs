using CRM_for_English_School.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(PersonDataTransferObject person);
        void EditPerson(PersonDataTransferObject person);
        void DeletePerson(int id);
        PersonDataTransferObject GetWorker(int id);
        IEnumerable<PersonDataTransferObject> GetPerson();
        void Dispose();
    }
}
