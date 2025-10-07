using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1_AP1_JamesDePeña.Models;

public class TiposHuacales
{
    [Key]
    public int TipoId { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    public string Descripcion { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "La existencia debe ser igual o mayor que 0.")]
    public int Existencia { get; set; }

    [InverseProperty("TipoHuacal")]
    public virtual ICollection<EntradasHuacalesDetalle> EntradasHuacalesDetalle { get; set; } = new List<EntradasHuacalesDetalle>();
}