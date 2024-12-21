using System;
using System.Collections.Generic;

namespace Pry_sistema_metroVia.Modelo;

public partial class Usuario
{
    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public byte[]? Qr { get; set; }

    public decimal Saldo { get; set; }

    public DateTime FechaRegist { get; set; }

    public string? CampoV01 { get; set; }

    public string? CampoN01 { get; set; }

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
