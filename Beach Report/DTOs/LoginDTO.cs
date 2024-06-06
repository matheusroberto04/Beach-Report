using System.ComponentModel.DataAnnotations;

namespace Beach_Report.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string CPF { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
