namespace mvc_crud.codefirst
{
    using entity;
    using entity.FluentAPI;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class mvccrudContext : DbContext
    {
        public mvccrudContext()
            : base("name=mvccrudContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("mvc-crud");

            //Map entity to table
            //modelBuilder.Entity<User>().ToTable("User");

            modelBuilder.Configurations.Add(new AddressEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }
}
