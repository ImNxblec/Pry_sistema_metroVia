using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Transaccion
{
    public int TransaccionId { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Monto { get; set; }

    public DateTime FechaHora { get; set; }

    public string Cedula { get; set; } = null!;

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual Usuario CedulaNavigation { get; set; } = null!;
}
