namespace Bookstore_ITProekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FistMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        ImgUrl = c.String(nullable: false),
                        Biography = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImgUrl = c.String(nullable: false),
                        Description = c.String(),
                        Author_Key = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.Author_Key)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Author_Key)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.PublishingHouses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ImgUrl = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                        MemberCard = c.String(),
                        Telephone = c.String(),
                        IsSubscribed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PublishingHouseBooks",
                c => new
                    {
                        PublishingHouse_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PublishingHouse_ID, t.Book_ID })
                .ForeignKey("dbo.PublishingHouses", t => t.PublishingHouse_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.PublishingHouse_ID)
                .Index(t => t.Book_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.PublishingHouseBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.PublishingHouseBooks", "PublishingHouse_ID", "dbo.PublishingHouses");
            DropForeignKey("dbo.Books", "Author_Key", "dbo.Authors");
            DropIndex("dbo.PublishingHouseBooks", new[] { "Book_ID" });
            DropIndex("dbo.PublishingHouseBooks", new[] { "PublishingHouse_ID" });
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropIndex("dbo.Books", new[] { "Author_Key" });
            DropTable("dbo.PublishingHouseBooks");
            DropTable("dbo.Customers");
            DropTable("dbo.PublishingHouses");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
