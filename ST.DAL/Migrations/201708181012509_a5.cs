namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparisler", "AdresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Siparisler", "AdresId");
            AddForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler");
            DropIndex("dbo.Siparisler", new[] { "AdresId" });
            DropColumn("dbo.Siparisler", "AdresId");
        }
    }
}
