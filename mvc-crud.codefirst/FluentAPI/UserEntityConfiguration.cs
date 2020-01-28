using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_crud.entity.FluentAPI
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            //Configure Column
            Property(p => p.FirstName)
                        .HasColumnName("FirstName")
                        .HasColumnOrder(2)
                        .HasColumnType("varchar(50)");

            //Configure Column
            Property(p => p.LastName)
                        .HasColumnName("LastName")
                        .HasColumnOrder(3)
                        .HasColumnType("varchar(50)");
        }
    }
}
