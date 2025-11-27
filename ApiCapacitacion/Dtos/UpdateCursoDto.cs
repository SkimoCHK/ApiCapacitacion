using System.ComponentModel.DataAnnotations;

namespace ApiCapacitacion.Dtos
{
  public class UpdateCursoDto
  {
    [Required]
    public int IdCurso { get; set; }

    [Required(ErrorMessage = "El campo nombre es obligatorio")]
    [MaxLength(100, ErrorMessage = "El maximo son 100 caracteres")]
    public string Nombre { get; set; }
    [Required]
    public int CupoMaximo { get; set; }
    [Required]
    public int Inscritos { get; set; }
  }
}
