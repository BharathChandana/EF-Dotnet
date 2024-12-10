namespace EF_Six.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandId = c.Int(nullable: false),
                        BName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Quantity = c.String(nullable: false, maxLength: 15),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        PTId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductType", t => t.PTId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.BrandId)
                .Index(t => t.PTId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        CName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        PTId = c.Int(nullable: false),
                        PTName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PTId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "PTId", "dbo.ProductType");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Product", "BrandId", "dbo.Brand");
            DropIndex("dbo.Product", new[] { "PTId" });
            DropIndex("dbo.Product", new[] { "BrandId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropTable("dbo.ProductType");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Brand");
        }
    }
}
