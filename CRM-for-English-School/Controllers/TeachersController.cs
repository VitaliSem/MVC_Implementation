using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;
        private readonly IOptions<FileModel> _fileConfig;
        private readonly IWebHostEnvironment _appEnvironment;

        public TeachersController(ITeacherService teacherervice,
            IMapper mapper,
            IOptions<FileModel> fileConfig,
            IWebHostEnvironment appEnvironment)
        {
            _teacherService = teacherervice;
            _mapper = mapper;
            _fileConfig = fileConfig;
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var teachers = await _teacherService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<TeacherModel>>(teachers));
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacherAsync(TeacherModel teacherModel)
        {
            if (!ModelState.IsValid)
                return View(teacherModel);
            if (teacherModel.PhotoFile != null)
                teacherModel.HasPhoto = true;
            byte[] bytesStream = SetImage(teacherModel);
            teacherModel.Photo = bytesStream;
            await _teacherService.CreateEntityAsync(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> EditTeacherAsync(int id)
        {
            var teacher = await _teacherService.GetEntityAsync(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpPost]
        public async Task<IActionResult> EditTeacherAsync(TeacherModel teacherModel)
        {
            if (!ModelState.IsValid)
                return View(teacherModel);
            if (teacherModel.PhotoFile != null)
                teacherModel.HasPhoto = true;
            byte[] bytesStream = SetImage(teacherModel);
            teacherModel.Photo = bytesStream;
            await _teacherService.EditEntityAsync(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTeacherAsync(int id)
        {
            await _teacherService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "Teachers");
        }
        private byte[] SetImage(TeacherModel teacherModel)
        {
            byte[] bytesStream = null;
            if(teacherModel.HasPhoto && teacherModel.PhotoFile == null)
            {
                return teacherModel.Photo;
            }
            else if (teacherModel.HasPhoto && teacherModel.PhotoFile != null)
            {
                using (var binaryReader = new BinaryReader(teacherModel.PhotoFile.OpenReadStream()))
                {
                    bytesStream = binaryReader.ReadBytes((int)teacherModel.PhotoFile.Length);
                }
                teacherModel.Photo = bytesStream;
            }
            else
            {
                string path = _appEnvironment.WebRootPath + "/Files/" + _fileConfig.Value.Name;
                using FileStream fileStream = new(path, FileMode.Open, FileAccess.Read);
                var binaryReader = new BinaryReader(fileStream);
                bytesStream = binaryReader.ReadBytes((int)new FileInfo(path).Length);
                teacherModel.Photo = bytesStream;
            }
            return bytesStream;
        }
    }
}
