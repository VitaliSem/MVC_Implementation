using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface ITeacherService : IBaseEntityService<Teacher>
    {
        Task<Teacher> GetTeacherByUserId(string userId);
    }
}
