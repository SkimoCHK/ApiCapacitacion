using ApiCapacitacion.Interfaces;
using ApiCapacitacion.Models;
using ApiCapacitacion.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCapacitacion.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CursoController : ControllerBase
  {
    private readonly ICursoRepository _repository;

    public CursoController(ICursoRepository repository){
      _repository = repository;
    }

    [HttpGet("ObtenerCursos")]
    public IActionResult GetCursos()
    {
      List<Curso> cursos = _repository.GetCursos();
      return Ok(cursos);
    }

  }
}
