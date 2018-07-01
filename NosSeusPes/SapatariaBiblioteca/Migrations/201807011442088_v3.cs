namespace SapatariaBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        id_Modelo = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cadarco = c.Boolean(nullable: false),
                        material = c.String(),
                        cor = c.String(),
                        preco = c.Single(nullable: false),
                        fotografias = c.String(),
                    })
                .PrimaryKey(t => t.id_Modelo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modeloes");
        }
    }
}
