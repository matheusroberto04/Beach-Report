using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beach_Report.Models
{
    [Table("Tabela_Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Nome_De_Usuario")]
        public string Nome { get; set; }
        [Required]
        [Column("CPF")]
        public int CPF { get; set;}
        [Required]
        [Column("Telefone")]
        public int Telefone { get; set; }
        [Required]
        [Column("Senha_Hash")]
        public string PasswordHash { get; set; }
        [Required]
        [EmailAddress]
        [Column("Email")]
        public string UserEmail { get; set; }

        public ICollection<Reportar>? Reportars { get; set; }  
        public ICollection<Descricao>? Descricao { get; set; }
        //[Required]
        //[Column("Usuario_Ativo")]
        //public bool IsActive { get; set; } = true;
    }
}
