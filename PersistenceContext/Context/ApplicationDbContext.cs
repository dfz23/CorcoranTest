using System.Reflection;

namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<DataFileUploader_DataFile> DataFileUploader_DataFile { get; set; }
        public virtual DbSet<DataFileUploader_DataFileDefinition_Fields> DataFileUploader_DataFileDefinition_Fields { get; set; }
        public virtual DbSet<DataFileUploader_DataFileDefinitions> DataFileUploader_DataFileDefinitions { get; set; }
        public virtual DbSet<DataFileUploader_DataTypes> DataFileUploader_DataTypes { get; set; }
        public virtual DbSet<DataFileUploader_FileTypes> DataFileUploader_FileTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataFileUploader_DataFile>()
                .Property(e => e.UniqueName)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFile>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFile>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinition_Fields>()
                .Property(e => e.UniqueName)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinition_Fields>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinitions>()
                .Property(e => e.UniqueName)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinitions>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinitions>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataFileDefinitions>()
                .HasMany(e => e.DataFileUploader_DataFileDefinition_Fields)
                .WithRequired(e => e.DataFileUploader_DataFileDefinitions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DataFileUploader_DataTypes>()
                .Property(e => e.UniqueName)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_DataTypes>()
                .HasMany(e => e.DataFileUploader_DataFileDefinition_Fields)
                .WithRequired(e => e.DataFileUploader_DataTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DataFileUploader_FileTypes>()
                .Property(e => e.UniqueName)
                .IsUnicode(false);

            modelBuilder.Entity<DataFileUploader_FileTypes>()
                .HasMany(e => e.DataFileUploader_DataFileDefinitions)
                .WithRequired(e => e.DataFileUploader_FileTypes)
                .WillCascadeOnDelete(false);
            
        }
    }
}
