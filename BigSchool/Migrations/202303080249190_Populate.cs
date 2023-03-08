namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories(ID,NAME) values (1,'Develop')");
            Sql("Insert into Categories(ID,NAME) values (2,'Dev Front-end')");
            Sql("Insert into Categories(ID,NAME) values (3,'Dev Back-end')");
            Sql("Insert into Categories(ID,NAME) values (4,'Dev Java')");
        }
        
        public override void Down()
        {
        }
    }
}
