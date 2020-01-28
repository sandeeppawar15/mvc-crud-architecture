namespace mvc_crud.codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAddresstable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Address1", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Address1", c => c.String());
        }
    }
}
