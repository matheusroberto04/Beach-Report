using System.ComponentModel.DataAnnotations;

namespace Beach_Report.DTOs
{
    public class CadastroDTO
    {
        [Required]
        public string Nome { get; set;}
        [Required]
        public int Telefone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int CPF { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
    }
}
