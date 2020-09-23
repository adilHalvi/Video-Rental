using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Web;
using Vidly_1.Models;

namespace Vidly_1.EntityConfigurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(255);
        }
    }
}