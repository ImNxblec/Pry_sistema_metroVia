using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Notificacion
{
    public int NotificacionId { get; set; }

    public string TipoNoti { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public DateTime FechaEnvio { get; set; }

    public string Estado { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual Usuario CedulaNavigation { get; set; } = null!;
}
