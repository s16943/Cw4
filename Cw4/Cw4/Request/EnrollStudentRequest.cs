using System;
using System.ComponentModel.DataAnnotations;



namespace Cw4.Requests
{
    public class EnrollStudentRequest
    {
        [Required]
        [RegularExpression("^s[0-9]+$")]
        public string IndexNumber { get; set; }

        [Required(ErrorMessage = "Podaj imię")]
        [MaxLength(60)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [MaxLength(60)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Podaj date urodzenia")]
        public String BirthDate { get; set; }

        [Required]
        public string Studies { get; set; }
    }
}