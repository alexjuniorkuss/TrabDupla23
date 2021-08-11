namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBebidas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Tipo = c.String(),
                        TeorAlcoolico = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Lanches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lanches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        QtdItens = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Bebidas");
        }
    }
}
