using ApiCapacitacion.Dtos;
using ApiCapacitacion.Models;

namespace ApiCapacitacion.Interfaces
{
  public interface ICursoRepository
  {
    List<Curso> GetCursos();
    Curso GetCursoById(int id);
    Curso AddCurso(CreateCursoDto curso);
    Curso UpdateCurso(UpdateCursoDto curso);
  }
}
