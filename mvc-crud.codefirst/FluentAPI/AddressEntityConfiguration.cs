using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_crud.entity.FluentAPI
{
    public class AddressEntityConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressEntityConfiguration()
        {
            //Configure Column
            Property(p => p.Address1)
                        .HasColumnName("DoB")
                        .HasColumnOrder(3)
                        .HasColumnType("datetime2");

            //Configure Column
            Property(p => p.Address2)
                        .IsRequired()
                        .HasColumnType("datetime2");
        }
    }
}
