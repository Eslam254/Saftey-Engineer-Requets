using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Models.Mappings
{
    public class RequestsMapping : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(c => c.newId)
               .HasColumnName("Idn");

            builder.Property(c => c.EmployeeName)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
