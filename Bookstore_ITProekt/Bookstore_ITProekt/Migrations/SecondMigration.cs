using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Bookstore_ITProekt.Migrations
{
    public class SecondMigration : DbMigration
    {
        public SecondMigration()
        {
        }

        public override void Up()
        {
            /*Sql("INSERT INTO Customers (Name) VALUES ('Ritta Whiteson') (Address) VALUES ('LondonBridge31') (Age) VALUES('17') (MemberCard) VALUE('1111') (Telephone) VALUE('077 010 101') (IsSubscribed) VALUE('Yes')");
            Sql("INSERT INTO Customers (Name) VALUES ('Dan Russel') (Address) VALUES ('TenthWall 223') (Age) VALUES('24') (MemberCard) VALUE('1112') (Telephone) VALUE('222 333 101') (IsSubscribed) VALUE('Yes')");

            Sql("INSERT INTO Customers (Name) VALUES ('Dereck Willson') (Address) VALUES ('3rdMay7thHill') (Age) VALUES('28') (MemberCard) VALUE('1113') (Telephone) VALUE('888 989101') (IsSubscribed) VALUE('Yes')");
            Sql("INSERT INTO Customers (Name) VALUES ('Olivia Woods') (Address) VALUES ('RoyalHills22') (Age) VALUES('31') (MemberCard) VALUE('1114') (Telephone) VALUE('015 316191') (IsSubscribed) VALUE('Yes')");
            */
            Sql("INSERT INTO Customers (Name) VALUEs ('Rita Whiteson')");
        }
        public override void Down()
        {
            
        }
    }
}