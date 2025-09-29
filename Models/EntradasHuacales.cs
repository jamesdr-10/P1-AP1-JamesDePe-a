using System.ComponentModel.DataAnnotations;

namespace P1_AP1_JamesDePeña.Models;

public class EntradasHuacales
{
    [Key]
    public int IdEntrada { get; set; }

    [Required(ErrorMessage = "La fecha es obligatoria.")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede tener letras y espacios.")]
    public string NombreCliente { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0.")]
    public int Cantidad { get; set; }

    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0.")]
    public double Precio { get; set; }
}