namespace MeuPrimeiroBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoInventario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        InventarioID = c.Int(nullable: false, identity: true),
                        JogadorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioID)
                .ForeignKey("dbo.Jogadors", t => t.JogadorID, cascadeDelete: true)
                .Index(t => t.JogadorID);
            
            AddColumn("dbo.Items", "Inventario_InventarioID", c => c.Int());
            CreateIndex("dbo.Items", "Inventario_InventarioID");
            AddForeignKey("dbo.Items", "Inventario_InventarioID", "dbo.Inventarios", "InventarioID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Inventario_InventarioID", "dbo.Inventarios");
            DropForeignKey("dbo.Inventarios", "JogadorID", "dbo.Jogadors");
            DropIndex("dbo.Items", new[] { "Inventario_InventarioID" });
            DropIndex("dbo.Inventarios", new[] { "JogadorID" });
            DropColumn("dbo.Items", "Inventario_InventarioID");
            DropTable("dbo.Inventarios");
        }
    }
}
