using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Academico.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do Curso é obrigatório")]
        public string Nome { get; set; }
        [DisplayName("Carga Horária")]
        [IntegerValidator(MinValue = 21)]
        [Required(ErrorMessage = "A Carga Horária deve ser maior que 20!")]
        public int CargaHoraria { get; set; }

        [DisplayName("Departamento")]
        public int DepartamentoID { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
