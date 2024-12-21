using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Estacion
{
    public int EstacionId { get; set; }

    public string NombreEstacion { get; set; } = null!;

    public int Orden { get; set; }

    public int RutaId { get; set; }

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual Rutum Ruta { get; set; } = null!;

    public virtual ICollection<Viaje> ViajeEstacionFinNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeEstacionInicioNavigations { get; set; } = new List<Viaje>();
}
