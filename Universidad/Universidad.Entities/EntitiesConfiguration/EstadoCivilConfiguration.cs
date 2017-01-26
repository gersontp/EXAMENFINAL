using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Context.Clases;

namespace Universidad.Entities.EntitiesConfiguration
{
    class EstadoCivilConfiguration : EntityTypeConfiguration<EstadoCivil>
    {

        public EstadoCivilConfiguration()
        {
            ToTable("EstadoCivil");

            HasKey(b => b.EstadoCivilId);

            Property(b => b.EstadoCivilId).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(b => b.Descripcion)
                .HasMaxLength(50);
        }
            
    }
}
