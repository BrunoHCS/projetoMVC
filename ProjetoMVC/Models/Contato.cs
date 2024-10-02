using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O número de telefone é obrigatório.")]
        [RegularExpression(@"\(\d{2}\) \d{5}-\d{4}", ErrorMessage = "O telefone deve estar no formato (XX) XXXXX-XXXX.")]
        public string Telefone { get; set; }

        public bool Ativo { get; set; }
    }
}
