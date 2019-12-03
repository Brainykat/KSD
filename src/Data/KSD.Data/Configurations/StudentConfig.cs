using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.Data.Configurations
{
	public class StudentConfig : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.OwnsOne(p => p.Name, a =>
			{
				a.Property(p => p.Sur).IsRequired().HasMaxLength(50);
				a.Property(p => p.First).HasMaxLength(50);
				a.Property(p => p.Middle).HasMaxLength(50).HasDefaultValue("");
			});
			builder.Property(e => e.AdmissionNumber).HasMaxLength(20)
				.IsRequired();
			builder.Property(e => e.Grade).HasMaxLength(12)
				.IsRequired();
		}
	}
}
