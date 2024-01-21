using System;
using System.Collections.Generic;
using DataAccessLayer.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context;

public partial class DbfirstApproachContext : DbContext
{
    public DbfirstApproachContext()
    {
    }

    public DbfirstApproachContext(DbContextOptions<DbfirstApproachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bus> Buses { get; set; }

    public virtual DbSet<BusRoute> BusRoutes { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-JFDKH3EF\\MSSQLSERVER22;Database=DBFirstApproach;Trusted_Connection=false;Encrypt=False;TrustServerCertificate=False;Connect Timeout=30;user id=sa;password=test;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bus>(entity =>
        {
            entity.HasKey(e => e.BusId).HasName("PK_BusID");

            entity.ToTable("Bus");

            entity.Property(e => e.BusId).HasColumnName("BusID");
            entity.Property(e => e.BusName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BusNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BusNO");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InsurenceId).HasColumnName("insurenceID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BusRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BusRoute__3214EC07288FACA9");

            entity.ToTable("BusRoute");

            entity.Property(e => e.BusId).HasColumnName("BusID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RouteNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RouteNO");
            entity.Property(e => e.Startpoint)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tripcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.ViaRoute)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Bus).WithMany(p => p.BusRoutes)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK_BusID");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA4774784BCE1");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LocationID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.State).WithMany(p => p.Locations)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_StateID");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__State__C3BA3B5A8B9DE0E4");

            entity.ToTable("State");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("StateID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StateName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCAC192E9DE9");

            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
