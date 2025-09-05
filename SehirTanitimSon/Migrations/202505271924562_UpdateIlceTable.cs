namespace SehirTanitimSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIlceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ilces", "Aciklama", c => c.String(maxLength: 300));
            DropColumn("dbo.Ilces", "Nufus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ilces", "Nufus", c => c.Int(nullable: false));
            DropColumn("dbo.Ilces", "Aciklama");
        }
    }
}
