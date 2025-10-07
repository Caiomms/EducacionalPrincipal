using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento 
    {
        public int Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O Nome do Departamento é obrigatório")]
        public string Nome { get; set; }
        public Instituicao? Instituicao { get; set; }

        [DisplayName("Instituição")]
        public long InstituicaoID { get; set; }
    }
}
