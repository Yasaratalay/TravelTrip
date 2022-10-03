namespace TravelTrip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kullanici = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdresBlogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        AdresAcik = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        Konum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                        BlogImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yorumlars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Email = c.String(),
                        Yorum = c.String(),
                        Blog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .Index(t => t.Blog_Id);
            
            CreateTable(
                "dbo.Hakkimizdas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FotografUrl = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Email = c.String(),
                        Konu = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorumlars", "Blog_Id", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "Blog_Id" });
            DropTable("dbo.Iletisims");
            DropTable("dbo.Hakkimizdas");
            DropTable("dbo.Yorumlars");
            DropTable("dbo.Blogs");
            DropTable("dbo.AdresBlogs");
            DropTable("dbo.Admins");
        }
    }
}
