namespace General_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        ContactInfo = c.String(nullable: false),
                        IsPleasant = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            AddColumn("dbo.Products", "CustomerID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CustomerID");
            DropTable("dbo.Customers");
        }
    }
}
