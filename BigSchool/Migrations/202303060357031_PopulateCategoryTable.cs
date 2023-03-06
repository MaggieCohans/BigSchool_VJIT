namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories(ID,NAME) values (1,'Develop')");
            Sql("Insert into Categories(ID,NAME) values (2,'Dev Front-end')");
            Sql("Insert into Categories(ID,NAME) values (3,'Dev Back-end')");
        }
        
        public override void Down()
        {
        }
    }
}
