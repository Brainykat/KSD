using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.Data.Configurations
{
    public class ParentConfig : IEntityTypeConfiguration<Parent>
	{
		public void Configure(EntityTypeBuilder<Parent> builder)
		{
			builder.OwnsOne(p => p.Name, a =>
			{
				a.Property(p => p.Sur).IsRequired().HasMaxLength(50);
				a.Property(p => p.First).HasMaxLength(50);
				a.Property(p => p.Middle).HasMaxLength(50).HasDefaultValue("");
			});
			builder.Property(e => e.Phone).HasMaxLength(15)
				.IsRequired();
			builder.Property(e => e.Phone2).HasMaxLength(15);
			builder.Property(e => e.PhysicalLocation).HasMaxLength(150)
				.IsRequired();
			builder.Property(e => e.Email).HasMaxLength(50)
				.IsRequired();
		}
	}
}

