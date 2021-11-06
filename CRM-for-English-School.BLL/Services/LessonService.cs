using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Services
{
    public class LessonService : BaseEntityService<Lesson>, ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository) : base(lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public Task<IEnumerable<Lesson>> GetLessonsAsync()
        {
            return _lessonRepository.GetAllAsync();
        }
    }
}
