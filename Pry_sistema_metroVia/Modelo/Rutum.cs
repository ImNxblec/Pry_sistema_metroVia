using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Rutum
{
    public int RutaId { get; set; }

    public string NombreRuta { get; set; } = null!;

    public decimal Costo { get; set; }

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual ICollection<Estacion> Estacions { get; set; } = new List<Estacion>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
