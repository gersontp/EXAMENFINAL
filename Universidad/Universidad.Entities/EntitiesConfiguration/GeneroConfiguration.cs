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
    class GeneroConfiguration : EntityTypeConfiguration<Genero>
    {
        public GeneroConfiguration ()
	{
        ToTable("Genero");

        HasKey(b => b.GeneroId);

        Property(b => b.GeneroId).
            HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        Property(b => b.Descripcion)
            .HasMaxLength(50);
	}  
        
       

    }
}
