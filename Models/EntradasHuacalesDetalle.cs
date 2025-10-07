﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1_AP1_JamesDePeña.Models;

public class EntradasHuacalesDetalle
{
    [Key]
    public int DetalleId { get; set; }

    public int IdEntrada { get; set; }

    public int TipoId { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    [ForeignKey("IdEntrada")]
    [InverseProperty("EntradasHuacalesDetalle")]
    public virtual EntradasHuacales EntradaHuacal { get; set; }

    [ForeignKey("TipoId")]
    [InverseProperty("EntradasHuacalesDetalle")]
    public virtual TiposHuacales TipoHuacal { get; set; }
}