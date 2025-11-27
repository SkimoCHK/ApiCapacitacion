namespace ApiCapacitacion.Models
{
  public class Curso
  {
    public int IdCurso { get; set; }
    public string Nombre { get; set; }
    public int CupoMaximo { get; set; }
    public int Inscritos { get; set; }
  }
}
