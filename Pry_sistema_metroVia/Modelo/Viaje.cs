using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Viaje
{
    public int ViajeId { get; set; }

    public DateTime? FechaHora { get; set; }

    public decimal Costo { get; set; }

    public string Cedula { get; set; } = null!;

    public int RutaId { get; set; }

    public int EstacionInicio { get; set; }

    public int EstacionFin { get; set; }

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual Usuario CedulaNavigation { get; set; } = null!;

    public virtual Estacion EstacionFinNavigation { get; set; } = null!;

    public virtual Estacion EstacionInicioNavigation { get; set; } = null!;

    public virtual Rutum Ruta { get; set; } = null!;
}
