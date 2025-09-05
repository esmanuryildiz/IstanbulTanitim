namespace SehirTanitimSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTuristikYerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TuristikYers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Aciklama = c.String(nullable: false),
                        ResimUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TuristikYers");
        }
    }
}
