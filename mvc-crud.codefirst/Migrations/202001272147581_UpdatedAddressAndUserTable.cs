namespace mvc_crud.codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAddressAndUserTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "PostalCode", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "CreatedOn", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "UpdatedOn", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "EmailId", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "MobileNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "DOB", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "CreatedOn", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "CreatedOn", c => c.String());
            AlterColumn("dbo.Users", "Gender", c => c.String());
            AlterColumn("dbo.Users", "DOB", c => c.String());
            AlterColumn("dbo.Users", "MobileNumber", c => c.String());
            AlterColumn("dbo.Users", "EmailId", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Addresses", "UpdatedOn", c => c.String());
            AlterColumn("dbo.Addresses", "CreatedOn", c => c.String());
            AlterColumn("dbo.Addresses", "PostalCode", c => c.String());
            AlterColumn("dbo.Addresses", "Country", c => c.String());
            AlterColumn("dbo.Addresses", "State", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
        }
    }
}
