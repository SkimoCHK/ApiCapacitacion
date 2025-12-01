using ApiCapacitacion.Dtos;
using ApiCapacitacion.Interfaces;
using ApiCapacitacion.Models;
using Npgsql;

namespace ApiCapacitacion.Repositories
{
  public class CursoRepository : ICursoRepository
  {
    private readonly PostgreSqlConfiguration _postgreSqlConfiguration;

    public CursoRepository(PostgreSqlConfiguration postgreSqlConfiguration)
    {
      _postgreSqlConfiguration = postgreSqlConfiguration;
    }

    private string GetConnection()
    {
      return _postgreSqlConfiguration.GetConnectionString();
    }


    public Curso AddCurso(CreateCursoDto curso)
    {
      throw new NotImplementedException();
    }

    public Curso GetCursoById(int id)
    {
      throw new NotImplementedException();
    }

    public List<Curso> GetCursos()
    {
      List<Curso> cursos = [];
      string query = "SELECT * FROM FUN_GET_CURSOS()";
      string connectionString = GetConnection();

      using(NpgsqlConnection connection = new(connectionString))
      {
        connection.Open();
        var cmd = new NpgsqlCommand(query, connection);
        using(var reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            Curso curso = new Curso();
            curso.IdCurso = reader.GetInt32(reader.GetOrdinal("idcurso"));
            curso.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
            curso.CupoMaximo = reader.GetInt32(reader.GetOrdinal("cupomaximo"));
            curso.Inscritos = reader.GetInt32(reader.GetOrdinal("inscritos"));

            cursos.Add(curso);
          }
        }
      }
      return cursos;
    }


    public Curso UpdateCurso(UpdateCursoDto curso)
    {
      throw new NotImplementedException();
    }
  }
}
