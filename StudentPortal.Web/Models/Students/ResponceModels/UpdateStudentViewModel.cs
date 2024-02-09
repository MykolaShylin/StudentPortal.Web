using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models.Students.ResponceModels
{
    public class UpdateStudentViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is not specified")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Allow from 3 to 30 characters")]
        [RegularExpression("^[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "The name must contain only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is not specified")]
        [EmailAddress(ErrorMessage = "Email format is not correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is not specified")]
        [Phone(ErrorMessage = "Phone type must be like +380973695812")]
        [RegularExpression(@"^((\+380)+([0-9]){9})$", ErrorMessage = "Phone type must be like +380973695812")]
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
