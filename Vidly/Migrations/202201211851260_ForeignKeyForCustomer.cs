namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyForCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropColumn("dbo.Customers", "MembershitTypeId");
            RenameColumn(table: "dbo.Customers", name: "MembershipType_Id", newName: "MembershitTypeId");
            AlterColumn("dbo.Customers", "MembershitTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershitTypeId");
            AddForeignKey("dbo.Customers", "MembershitTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershitTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershitTypeId" });
            AlterColumn("dbo.Customers", "MembershitTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Customers", name: "MembershitTypeId", newName: "MembershipType_Id");
            AddColumn("dbo.Customers", "MembershitTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
