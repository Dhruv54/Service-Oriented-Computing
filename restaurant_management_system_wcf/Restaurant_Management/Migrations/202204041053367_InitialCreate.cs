namespace Restaurant_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Category = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 450),
                        Role = c.String(nullable: false),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecureToken = c.String(),
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                        Owner = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "ItemId", "dbo.Items");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "ItemId" });
            DropTable("dbo.Properties");
            DropTable("dbo.Tokens");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Items");
        }
    }
}
