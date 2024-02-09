using AutoMapper;
using StudentPortal.Web.Models.Students.ResponceModels;

namespace StudentPortal.Web.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, NewStudentViewModel>().ReverseMap();
            CreateMap<Student, UpdateStudentViewModel>().ReverseMap();
            CreateMap<Student, StudentViewModel>().ReverseMap();
        }
    }
}
