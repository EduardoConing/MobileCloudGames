namespace MeuPrimeiroBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoJogador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        JogadorID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Nome = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.JogadorID);
            
            AddColumn("dbo.Items", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Ativo");
            DropTable("dbo.Jogadors");
        }
    }
}
