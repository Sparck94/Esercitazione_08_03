using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace acc_task_gestione_impiegati.Models;

public partial class AccTaskGestioneImpiegatiContext : DbContext
{
    public AccTaskGestioneImpiegatiContext()
    {
    }

    public AccTaskGestioneImpiegatiContext(DbContextOptions<AccTaskGestioneImpiegatiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cittum> Citta { get; set; }

    public virtual DbSet<Impiegato> Impiegatos { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-10\\SQLEXPRESS;Database=acc_task_gestione_impiegati;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cittum>(entity =>
        {
            entity.HasKey(e => e.CittaId).HasName("PK__Citta__3EF53F318CE4BCC8");

            entity.HasIndex(e => e.NomeCitta, "UQ__Citta__502E5D18EDD0AA15").IsUnique();

            entity.Property(e => e.CittaId).HasColumnName("cittaID");
            entity.Property(e => e.NomeCitta)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_citta");
            entity.Property(e => e.ProvinciaRif).HasColumnName("provinciaRIF");

            entity.HasOne(d => d.ProvinciaRifNavigation).WithMany(p => p.Citta)
                .HasForeignKey(d => d.ProvinciaRif)
                .HasConstraintName("FK__Citta__provincia__4222D4EF");
        });

        modelBuilder.Entity<Impiegato>(entity =>
        {
            entity.HasKey(e => e.ImpiegatoId).HasName("PK__Impiegat__C7A20D1289712101");

            entity.ToTable("Impiegato");

            entity.HasIndex(e => e.Matricola, "UQ__Impiegat__2C2751BAF56AB69D").IsUnique();

            entity.Property(e => e.ImpiegatoId).HasColumnName("impiegatoID");
            entity.Property(e => e.CittaResidenza)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("citta_residenza");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.DataNascita).HasColumnName("data_nascita");
            entity.Property(e => e.IndirizzoResidenza)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("indirizzo_residenza");
            entity.Property(e => e.Matricola)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.ProvinciaResidenza)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("provincia_residenza");
            entity.Property(e => e.Reparto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("reparto");
            entity.Property(e => e.Ruolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ruolo");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProvinciaId).HasName("PK__Provinci__671F13451B2D25C5");

            entity.HasIndex(e => e.NomeProvincia, "UQ__Provinci__211EBE84B1F84AF5").IsUnique();

            entity.HasIndex(e => e.Sigla, "UQ__Provinci__3C47D519728A0F3E").IsUnique();

            entity.Property(e => e.ProvinciaId).HasColumnName("provinciaID");
            entity.Property(e => e.NomeProvincia)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_provincia");
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("sigla");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoId).HasName("PK__Reparto__612C4F363097AD26");

            entity.ToTable("Reparto");

            entity.Property(e => e.RepartoId).HasColumnName("repartoID");
            entity.Property(e => e.NomeReparto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_reparto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
