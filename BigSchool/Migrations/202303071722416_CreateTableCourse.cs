namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "datetime_Id", newName: "CategoryId");
            RenameIndex(table: "dbo.Courses", name: "IX_datetime_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_CategoryId", newName: "IX_datetime_Id");
            RenameColumn(table: "dbo.Courses", name: "CategoryId", newName: "datetime_Id");
        }
    }
}
