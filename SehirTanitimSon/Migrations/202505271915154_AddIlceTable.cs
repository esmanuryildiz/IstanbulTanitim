namespace SehirTanitimSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIlceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Nufus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ilces");
        }
    }
}
