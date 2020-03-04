using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ValueConfiguration : IEntityTypeConfiguration<Domain.Value>
    {
        public void Configure(EntityTypeBuilder<Value> builder)
        {
            builder.HasData(
                 new Value { Id = 1, Name = "Value 101" },
                 new Value { Id = 2, Name = "Value 102" },
                 new Value { Id = 3, Name = "Value 103" }
            );
        }
    }
}