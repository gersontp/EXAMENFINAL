using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Context.Clases;
using Universidad.Entities;


namespace Universidad.Entities.EntitiesConfiguration
{
    class AlumnoConfiguration : EntityTypeConfiguration<Alumno>
    {

        public AlumnoConfiguration()
        {
            ToTable("Alumno");

            HasKey(b => b.AlumnoId);

            Property(b => b.AlumnoId).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(b => b.Codigo)
                .HasMaxLength(10);

            Property(b => b.ApellidoPaterno)
                .HasMaxLength(50);

            Property(b => b.ApellidoMaterno)
               .HasMaxLength(50);

            Property(b => b.Created);

             Property(b => b.Nombres)
               .HasMaxLength(50);
          

             HasRequired(b => b.Genero)
                .WithMany(b => b.Alumno)
                .HasForeignKey(b => b.GeneroId);

             HasRequired(b => b.EstadoCivil)
                 .WithMany(b => b.Alumno)
                 .HasForeignKey(b => b.EstadoCivilId);


        }
    }
}
