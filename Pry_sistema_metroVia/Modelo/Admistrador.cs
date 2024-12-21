using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Admistrador
{
    public int AdminId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }
}
