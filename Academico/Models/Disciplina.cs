using System.Configuration;

namespace Academico.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [IntegerValidator(MinValue = 10, MaxValue =500)]
        public int CargaHoraria { get; set; }
        public ICollection<CursoDisciplina> CursosDisciplinas { get; set; }

    }
}
