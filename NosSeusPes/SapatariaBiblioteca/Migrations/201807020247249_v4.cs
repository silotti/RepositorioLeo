namespace SapatariaBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Items", newName: "Estoques");
            DropPrimaryKey("dbo.Estoques");
            AddColumn("dbo.Estoques", "id_Estoque", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Estoques", "id_Estoque");
            DropColumn("dbo.Estoques", "id_Item");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoques", "id_Item", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Estoques");
            DropColumn("dbo.Estoques", "id_Estoque");
            AddPrimaryKey("dbo.Estoques", "id_Item");
            RenameTable(name: "dbo.Estoques", newName: "Items");
        }
    }
}
