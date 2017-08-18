namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FirmaUrunler", "UrunFiyat", c => c.Decimal(nullable: false, precision: 7, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FirmaUrunler", "UrunFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
