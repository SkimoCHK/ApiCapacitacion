using System.ComponentModel.DataAnnotations;

namespace ApiCapacitacion.Dtos
{
  public class CreateCursoDto
  {
    [Required(ErrorMessage = "El campo nombre es obligatorio")]
    [MaxLength(100, ErrorMessage = "El maximo de caracteres son 100")]
    public string Nombre { get; set; }
    [Required]
    public int CupoMaximo { get; set; }
    [Required]
    public int Inscritos { get; set; }
  }
}
