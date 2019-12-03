using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.Data.Configurations
{
	public class MealConfig : IEntityTypeConfiguration<Meal>
	{
		public void Configure(EntityTypeBuilder<Meal> builder)
		{
			builder.Property(e => e.OrderTime)
				.IsRequired();
		}
	}
}
