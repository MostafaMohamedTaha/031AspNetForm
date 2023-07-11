using System.ComponentModel.DataAnnotations;
namespace form.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="please enter employee id")]
        public int EmpId { get; set; }
        [Required(ErrorMessage = "please enter employee first name")]
        public string FistName { get; set; }
        [Required(ErrorMessage = "please enter employee last name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "please enter employee email valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter employee age")]
        public int Age { get; set; }
    }
}
