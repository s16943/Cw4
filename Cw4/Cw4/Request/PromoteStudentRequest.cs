using System.ComponentModel.DataAnnotations;

namespace Cw4.Requests
{
    public class PromoteStudentRequest
    {
        [Required(ErrorMessage = "Nazwa Kierunku jest wymagana")]
        public string Studies { get; set; }
        [Required(ErrorMessage = "Wymagany jest numer semestru")]
        [RegularExpression("[1-9][0-9]{0,1}")]
        public int Semester { get; set; }
    }
}
