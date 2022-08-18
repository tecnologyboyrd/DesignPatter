using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DesignPattern.Models
{
    public partial class DesignPatternsContext : DbContext
    {
        public DesignPatternsContext()
        {
        }

        public DesignPatternsContext(DbContextOptions<DesignPatternsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Prueba> Pruebas { get; set; } = null!;
        public virtual DbSet<RejemploPu> RejemploPus { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRoleAssignment> UserRoleAssignments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ITPROE15; Database=DesignPatterns; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("PK_Log");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.PermissionId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AutoSec).ValueGeneratedOnAdd();

                entity.Property(e => e.Desciption)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.ToTable("Prueba");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RejemploPu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REJEMPLO_PU");

                entity.Property(e => e.Qualification).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RecordId).ValueGeneratedOnAdd();

                entity.Property(e => e.Student)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.Description, "Uq_RolDescription")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AutoSec).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoSeq).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserFullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoleAssignment>(entity =>
            {
                entity.ToTable("UserRoleAssignment");

                entity.Property(e => e.UserRoleAssignmentId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AutoSec).ValueGeneratedOnAdd();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleAssignments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleAssignmentId_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
