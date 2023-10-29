#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PrimeraConexion.Models;

public class Mascota{
    [Key]
    public int IdMascota { get; set; }

    [Required(ErrorMessage = "Debe ingresar un nombre.")]
    [MinLength(2, ErrorMessage = "El nombre de us mascota debe mínimo 2 letras.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar un tipo para su mascota.")]
    public string TipoMascota { get; set; }

    [Required(ErrorMessage = "Debe ingresar la edad.")]
    [Range(0, Int32.MaxValue, ErrorMessage = "La edad debe ser desde 0 años.")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "Debe ingresar si tiene pelo o no.")]
    public bool TienePelo { get; set; }
}