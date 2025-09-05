namespace SehirTanitimSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNufusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nufus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Yil = c.Int(nullable: false),
                        Sayi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nufus");
        }
    }
}
