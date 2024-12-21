using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pry_sistema_metroVia.Modelo;

namespace Pry_sistema_metroVia.Context;

public partial class sistema_metroViaContext : DbContext
{
    public sistema_metroViaContext()
    {
    }

    public sistema_metroViaContext(DbContextOptions<sistema_metroViaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admistrador> Admistradors { get; set; }

    public virtual DbSet<Estacion> Estacions { get; set; }

    public virtual DbSet<Notificacion> Notificacions { get; set; }

    public virtual DbSet<Rutum> Ruta { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Viaje> Viajes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=EALIAGA-TI\\SQLEXPRESS; Initial Catalog=EvaluaDocente; Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admistrador>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__ADMISTRA__59AF14B514BD46C1");

            entity.ToTable("ADMISTRADOR");

            entity.HasIndex(e => e.Mail, "UQ__ADMISTRA__603F496B852BDD55").IsUnique();

            entity.HasIndex(e => e.Nombre, "UQ__ADMISTRA__B21D0AB9E0A11D9D").IsUnique();

            entity.Property(e => e.AdminId).HasColumnName("ADMIN_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Estacion>(entity =>
        {
            entity.HasKey(e => e.EstacionId).HasName("PK__ESTACION__6CCF2B0161837A47");

            entity.ToTable("ESTACION");

            entity.Property(e => e.EstacionId).HasColumnName("ESTACION_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.NombreEstacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTACION");
            entity.Property(e => e.RutaId).HasColumnName("RUTA_ID");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Estacions)
                .HasForeignKey(d => d.RutaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ESTACION__RUTA_I__12FDD1B2");
        });

        modelBuilder.Entity<Notificacion>(entity =>
        {
            entity.HasKey(e => e.NotificacionId).HasName("PK__NOTIFICA__5318F8DAB649E55D");

            entity.ToTable("NOTIFICACION");

            entity.Property(e => e.NotificacionId).HasColumnName("NOTIFICACION_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente")
                .IsFixedLength()
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaEnvio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENVIO");
            entity.Property(e => e.Mensaje)
                .HasColumnType("text")
                .HasColumnName("MENSAJE");
            entity.Property(e => e.TipoNoti)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_NOTI");

            entity.HasOne(d => d.CedulaNavigation).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.Cedula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NOTIFICAC__CEDUL__24285DB4");
        });

        modelBuilder.Entity<Rutum>(entity =>
        {
            entity.HasKey(e => e.RutaId).HasName("PK__RUTA__77C014E21B7840F4");

            entity.ToTable("RUTA");

            entity.Property(e => e.RutaId).HasColumnName("RUTA_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.NombreRuta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_RUTA");
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.TransaccionId).HasName("PK__TRANSACC__74EF8E676FC04DFA");

            entity.ToTable("TRANSACCION");

            entity.Property(e => e.TransaccionId).HasColumnName("TRANSACCION_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");

            entity.HasOne(d => d.CedulaNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.Cedula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TRANSACCI__CEDUL__17C286CF");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK__USUARIO__06BB8449AACAEDA4");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Mail, "UQ__USUARIO__603F496B4BF5C41D").IsUnique();

            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.FechaRegist)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGIST");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Qr).HasColumnName("QR");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SALDO");
        });

        modelBuilder.Entity<Viaje>(entity =>
        {
            entity.HasKey(e => e.ViajeId).HasName("PK__VIAJE__F0E82FA8B48FFAE0");

            entity.ToTable("VIAJE");

            entity.Property(e => e.ViajeId).HasColumnName("VIAJE_ID");
            entity.Property(e => e.CampoN01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_N01");
            entity.Property(e => e.CampoV01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_V01");
            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.EstacionFin).HasColumnName("ESTACION_FIN");
            entity.Property(e => e.EstacionInicio).HasColumnName("ESTACION_INICIO");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.RutaId).HasColumnName("RUTA_ID");

            entity.HasOne(d => d.CedulaNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.Cedula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VIAJE__CEDULA__1B9317B3");

            entity.HasOne(d => d.EstacionFinNavigation).WithMany(p => p.ViajeEstacionFinNavigations)
                .HasForeignKey(d => d.EstacionFin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VIAJE__ESTACION___1E6F845E");

            entity.HasOne(d => d.EstacionInicioNavigation).WithMany(p => p.ViajeEstacionInicioNavigations)
                .HasForeignKey(d => d.EstacionInicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VIAJE__ESTACION___1D7B6025");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.RutaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VIAJE__RUTA_ID__1C873BEC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
