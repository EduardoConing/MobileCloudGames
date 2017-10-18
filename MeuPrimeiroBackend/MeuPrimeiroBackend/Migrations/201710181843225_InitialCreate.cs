namespace MeuPrimeiroBackend.Migrations
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
                        ItemID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20),
                        Descricao = c.String(),
                        DanoMaximo = c.Int(nullable: false),
                        DanoMinimo = c.Int(nullable: false),
                        Durabilidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
