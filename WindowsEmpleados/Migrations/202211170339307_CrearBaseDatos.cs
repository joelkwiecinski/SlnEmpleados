namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Legajo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Departamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentos", t => t.Departamento_Id)
                .Index(t => t.Departamento_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "Departamento_Id", "dbo.Departamentos");
            DropIndex("dbo.Empleados", new[] { "Departamento_Id" });
            DropTable("dbo.Empleados");
            DropTable("dbo.Departamentos");
        }
    }
}
