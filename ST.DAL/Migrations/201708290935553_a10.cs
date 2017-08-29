namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler");
            DropIndex("dbo.Siparisler", new[] { "AdresId" });
            AlterColumn("dbo.Siparisler", "AdresId", c => c.Int());
            CreateIndex("dbo.Siparisler", "AdresId");
            AddForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler");
            DropIndex("dbo.Siparisler", new[] { "AdresId" });
            AlterColumn("dbo.Siparisler", "AdresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Siparisler", "AdresId");
            AddForeignKey("dbo.Siparisler", "AdresId", "dbo.Adresler", "Id", cascadeDelete: true);
        }
    }
}
