namespace SapatariaBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id_Cliente = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        revenda = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_Cliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
