using StudentPortal.Web.Models;
using StudentPortal.Web.Models.Students.ResponceModels;

namespace StudentPortal.Web.Services.Students
{
    public interface IStudentService
    {
        public Task<ServiceResponce<NewStudentViewModel>> CreateAsync(NewStudentViewModel newStudent);
        public Task<ServiceResponce<UpdateStudentViewModel>> UpdateAsync(UpdateStudentViewModel newStudent);
        public Task DeleteAsync(Guid id);
        public Task<Student?> GetByIdAsync(Guid id);
        public Task<Student?> GetByEmailAsync(string name);
        public Task<List<StudentViewModel>> GetAsync();
    }
}
