using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Instituicao
    {
        public long InstituicaoID { get; set; }
        [Required(ErrorMessage = "O Nome da Instituição é obrigatório!")]
        public string Nome { get; set; }
        [RegularExpression(@"\(\d{2}\) \d{5}-\d{4}", ErrorMessage = "O telefone deve estar no formato (99) 99999-9999")]
        [Required(ErrorMessage = "O Telefone da Instituição é obrigatório!")]
        public string Telefone { get; set; }

    }
}
