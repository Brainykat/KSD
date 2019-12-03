using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.Data.Configurations
{
    public class SmsLogConfig : IEntityTypeConfiguration<SMSLog>
	{
		public void Configure(EntityTypeBuilder<SMSLog> builder)
		{
			builder.Property(e => e.msisdn).HasMaxLength(15)
				.IsRequired();
			builder.Property(e => e.Message).HasMaxLength(160)
				.IsRequired();
		}
	}
}
