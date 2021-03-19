using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppAPIEX.Models
{
    public partial class StudentsDbContext : DbContext
    {
        public StudentsDbContext()
        {
        }

        public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A9MT9F8;database=StudentsDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Student__CA1E5D78AA649AFF");

                entity.ToTable("Student");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.Scontact).HasMaxLength(20);

                entity.Property(e => e.Scourse).HasMaxLength(20);

                entity.Property(e => e.Semail).HasMaxLength(20);

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
