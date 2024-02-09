using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StudentPortal.Web.Models;
using StudentPortal.Web.Services.Students;

namespace StudentPortal.Web.Controllers
{
    public class StudentController(IStudentService _studentService, IMapper _mapper) : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(NewStudentViewModel newStudent)
        {
            if (!ModelState.IsValid)
            {
                return View(newStudent);
            }
            var responce = await _studentService.CreateAsync(newStudent);
            if (!responce.Success)
            {
                ModelState.AddModelError(responce.ModelErrorField, responce.ErrorMessage);
                return View(responce.Data);
            }
            return RedirectToAction(nameof(Logbook));
        }

        [HttpGet]
        public async Task<IActionResult> Logbook()
        {
            var students = await _studentService.GetAsync();

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> EditInfo(Guid id)
        {
            var student = await _studentService.GetByIdAsync(id);

            var updateStudent = _mapper.Map<UpdateStudentViewModel>(student);

            return View(updateStudent);
        }

        [HttpPost]
        public async Task<IActionResult> EditInfoAsync(UpdateStudentViewModel updateStudent)
        {
            if (!ModelState.IsValid)
            {
                return View(updateStudent);
            }
            var responce = await _studentService.UpdateAsync(updateStudent);
            if (!responce.Success)
            {
                ModelState.AddModelError(responce.ModelErrorField, responce.ErrorMessage);
                return View(updateStudent);
            }

            return RedirectToAction(nameof(Logbook));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _studentService.DeleteAsync(id);
            return RedirectToAction(nameof(Logbook));
        }
    }
}
