namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparisler", "IstenilenZaman", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparisler", "IstenilenZaman");
        }
    }
}
