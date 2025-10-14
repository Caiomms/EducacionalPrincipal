using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class EducacionalContext : DbContext
    {
        public EducacionalContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Instituicao> Instituicoes { get; set; } = default;
        public DbSet<Departamento> Departamentos { get; set; } = default;
        public DbSet<Cursos> Cursos { get; set; } = default;
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<CursoDisciplina> CursoDisciplinas { get; set; } = default;
        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDisciplina>()
                .HasKey(cd => new { cd.CursoId, cd.DisciplinaId });
            modelBuilder.Entity<CursoDisciplina>()
                .HasOne(cd => cd.Cursos)
                .WithMany(c => c.CursosDisciplinas)
                .HasForeignKey(cd => cd.CursoId);
            modelBuilder.Entity<CursoDisciplina>()
                .HasOne(cd => cd.Disciplina)
                .WithMany(c => c.CursosDisciplinas)
                .HasForeignKey(cd => cd.DisciplinaId);
        }
    }
}
