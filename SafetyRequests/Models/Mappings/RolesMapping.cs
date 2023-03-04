using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Models.Mappings
{
    public class RolesMapping : IEntityTypeConfiguration<EmployeeRole>
    {
        public void Configure(EntityTypeBuilder<EmployeeRole> builder)
        {
            builder.Property(c => c.newId)
                .HasColumnName("Idn");
        }
    }
}