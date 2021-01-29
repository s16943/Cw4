using System.ComponentModel.DataAnnotations;

namespace Cw4.Requests
{
    public class PromotionRequest
    {
        [Required]
        public string Studies { get; set; }

        [Required]
        public int Semester { get; set; }
    }
}
