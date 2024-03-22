﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace task_eventi.Models;

public partial class TaskEventiContext : DbContext
{
    public TaskEventiContext()
    {
    }

    public TaskEventiContext(DbContextOptions<TaskEventiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Partecipante> Partecipantes { get; set; }

    public virtual DbSet<Risorsa> Risorsas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-10\\SQLEXPRESS;Database=task_eventi;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventoId).HasName("PK__Evento__DE07229C7B1884FE");

            entity.ToTable("Evento");

            entity.HasIndex(e => new { e.DataOra, e.Luogo }, "UQ__Evento__88D3CFE592DD067B").IsUnique();

            entity.Property(e => e.EventoId).HasColumnName("eventoID");
            entity.Property(e => e.Capacita).HasColumnName("capacita");
            entity.Property(e => e.DataOra)
                .HasColumnType("datetime")
                .HasColumnName("data_ora");
            entity.Property(e => e.Descrizione)
                .HasColumnType("text")
                .HasColumnName("descrizione");
            entity.Property(e => e.Luogo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("luogo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Partecipante>(entity =>
        {
            entity.HasKey(e => e.PartecipanteId).HasName("PK__Partecip__59BAFC0E9DAE23AA");

            entity.ToTable("Partecipante");

            entity.HasIndex(e => new { e.Biglietto, e.EventoRif }, "UQ__Partecip__37B11120257DB462").IsUnique();

            entity.Property(e => e.PartecipanteId).HasColumnName("partecipanteID");
            entity.Property(e => e.Biglietto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("biglietto");
            entity.Property(e => e.Contatto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contatto");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.EventoRif).HasColumnName("eventoRIF");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.EventoRifNavigation).WithMany(p => p.Partecipantes)
                .HasForeignKey(d => d.EventoRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partecipa__event__44FF419A");
        });

        modelBuilder.Entity<Risorsa>(entity =>
        {
            entity.HasKey(e => e.RisorsaId).HasName("PK__Risorsa__31473C99B7CA202C");

            entity.ToTable("Risorsa");

            entity.Property(e => e.RisorsaId).HasColumnName("risorsaID");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.Deleted)
                .HasColumnType("datetime")
                .HasColumnName("deleted");
            entity.Property(e => e.EventoRif).HasColumnName("eventoRIF");
            entity.Property(e => e.Fornitore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fornitore");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.Tipo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.EventoRifNavigation).WithMany(p => p.Risorsas)
                .HasForeignKey(d => d.EventoRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Risorsa__eventoR__47DBAE45");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
