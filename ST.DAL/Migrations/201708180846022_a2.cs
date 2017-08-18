namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firmalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 100),
                        Adres = c.String(maxLength: 200),
                        Telefon = c.String(maxLength: 11),
                        WebUrl = c.String(maxLength: 75),
                        OrtalamaTeslimSuresi = c.Byte(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        KullaniciId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.KullaniciId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.UrunKategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 100),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.KategoriAdi, unique: true);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 100),
                        UrunFotografYolu = c.String(),
                        UrunKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UrunKategoriler", t => t.UrunKategoriId, cascadeDelete: true)
                .Index(t => t.UrunAdi, unique: true)
                .Index(t => t.UrunKategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "UrunKategoriId", "dbo.UrunKategoriler");
            DropForeignKey("dbo.Firmalar", "KullaniciId", "dbo.AspNetUsers");
            DropIndex("dbo.Urunler", new[] { "UrunKategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropIndex("dbo.UrunKategoriler", new[] { "KategoriAdi" });
            DropIndex("dbo.Firmalar", new[] { "KullaniciId" });
            DropTable("dbo.Urunler");
            DropTable("dbo.UrunKategoriler");
            DropTable("dbo.Firmalar");
        }
    }
}
