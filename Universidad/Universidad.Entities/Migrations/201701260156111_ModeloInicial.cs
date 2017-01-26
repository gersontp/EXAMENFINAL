namespace Universidad.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.EstadoCivils", newName: "EstadoCivil");
            RenameTable(name: "dbo.Generoes", newName: "Genero");
            AlterColumn("dbo.Alumno", "Codigo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Alumno", "ApellidoPaterno", c => c.String(maxLength: 50));
            AlterColumn("dbo.Alumno", "ApellidoMaterno", c => c.String(maxLength: 50));
            AlterColumn("dbo.Alumno", "Nombres", c => c.String(maxLength: 50));
            AlterColumn("dbo.EstadoCivil", "Descripcion", c => c.String(maxLength: 50));
            AlterColumn("dbo.Genero", "Descripcion", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genero", "Descripcion", c => c.String());
            AlterColumn("dbo.EstadoCivil", "Descripcion", c => c.String());
            AlterColumn("dbo.Alumno", "Nombres", c => c.String());
            AlterColumn("dbo.Alumno", "ApellidoMaterno", c => c.String());
            AlterColumn("dbo.Alumno", "ApellidoPaterno", c => c.String());
            AlterColumn("dbo.Alumno", "Codigo", c => c.String());
            RenameTable(name: "dbo.Genero", newName: "Generoes");
            RenameTable(name: "dbo.EstadoCivil", newName: "EstadoCivils");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
