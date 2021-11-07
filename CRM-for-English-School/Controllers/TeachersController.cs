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
using Microsoft.AspNetCore.Identity;
using System;
using CRM_for_English_School.Configuration;
using UnidecodeSharpFork;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;
        private readonly IOptions<FileModel> _fileConfig;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOptions<EmailSenderOptions> _emailSenderOptions;
        private readonly IOptions<EmailTestReveiverOptions> _emailReceiverOptions;

        public TeachersController(ITeacherService teacherervice,
            IMapper mapper,
            IOptions<FileModel> fileConfig,
            IWebHostEnvironment appEnvironment,
            UserManager<IdentityUser> userManager,
            IOptions<EmailSenderOptions> emailSenderOptions,
            IOptions<EmailTestReveiverOptions> emailReceiverOptions)
        {
            _teacherService = teacherervice;
            _mapper = mapper;
            _fileConfig = fileConfig;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
            _emailSenderOptions = emailSenderOptions;
            _emailReceiverOptions = emailReceiverOptions;
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
            await SetTeacherRole(teacherModel);
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTeacherAsync(int id)
        {
            await _teacherService.DeleteEntityAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> SendEmailAsync(int id)
        {
            EmailService emailService = new(_emailSenderOptions, _emailReceiverOptions);
            var teacher = await _teacherService.GetEntityAsync(id);
            if (teacher.Email != _emailReceiverOptions.Value.Email)
                await emailService.SendEmailAsync(null, "Регистрация", GetMessage(teacher));
            else
                await emailService.SendEmailAsync(teacher.Email, "Регистрация", GetMessage(teacher));
            return RedirectToAction("Index");
        }

        private static string GetMessage(Teacher teacher)
        {
            string message = $"<h3>Hello {teacher.FirstName}. We are glad to see you in our team!</h3>\n";
            message += "<p>We suppose that you'll get a pleasure working at our company. Before we start our collaboration\n" +
                "we want to say that you need to create your person account in our corporation network. To creat an account, please\n" +
                "follow this link:\n\n</p>";
            message += "<a href=\"https://localhost:44308/Identity/Account/Login\">Sign In</a>";
            message += $"<p style=\"color: red;\">Pay attention that you need to use an email, which you have given to our manager - <b>{teacher.Email}</b>.\n</p>";
            message += $"<p style=\"color: red;\">Your password is <b>{teacher.LastName.Unidecode()}{teacher.BirthDate.Value.Year}</b>." +
                $" When you sign in into the system you can change the password.</p>";
            message += "<p>Great regards your English School!</p>";
            return message;
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
        private async Task SetTeacherRole(TeacherModel teacherModel)
        {
            IdentityUser teacher = new()
            {
                UserName = teacherModel.Email,
                NormalizedUserName = teacherModel.Email.ToUpper(),
                Email = teacherModel.Email,
                NormalizedEmail = teacherModel.Email.ToUpper(),
            };
            IdentityResult result = await _userManager.CreateAsync(teacher);
            if (result.Succeeded)
                await _userManager.AddToRoleAsync(teacher, "teacher");
        }
    }
}
