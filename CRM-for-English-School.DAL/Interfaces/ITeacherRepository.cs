using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Task<Teacher> GetTeacherByUserId(string userId);
    }
}
