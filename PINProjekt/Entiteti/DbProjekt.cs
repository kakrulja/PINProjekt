using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PINProjekt.Entiteti
{
    public partial class DbProjekt : DbContext
    {
        public DbProjekt()
        {
        }

        public DbProjekt(DbContextOptions<DbProjekt> options)
            : base(options)
        {
        }

        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=ProjectLaptop\\SQLEXPRESS;Initial Catalog=PINProjekt;Persist Security Info=false;User ID=Student; Password=test; integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserInfo");

                entity.Property(e => e.DatumKreiranja)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ime).HasMaxLength(50);

                entity.Property(e => e.Nadimak).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
