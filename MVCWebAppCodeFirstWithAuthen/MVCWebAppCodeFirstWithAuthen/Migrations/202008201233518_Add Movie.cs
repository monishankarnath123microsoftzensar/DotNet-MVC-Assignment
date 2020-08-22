namespace MVCWebAppCodeFirstWithAuthen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Gener", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Gener");
            DropColumn("dbo.Customers", "DOB");
        }
    }
}
