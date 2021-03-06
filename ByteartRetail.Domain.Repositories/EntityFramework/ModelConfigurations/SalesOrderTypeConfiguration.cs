﻿using System.Data.Entity.ModelConfiguration;
using ByteartRetail.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteartRetail.Domain.Repositories.EntityFramework.ModelConfigurations
{
    public class SalesOrderTypeConfiguration : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderTypeConfiguration()
        {
            HasKey(s => s.ID);
            Property(s => s.ID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Ignore(p => p.Subtotal);
        }
    }
}
