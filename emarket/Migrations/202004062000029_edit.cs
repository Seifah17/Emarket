namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE store RENAME Categories Address TO Category;");
            Sql("ALTER TABLE store RENAME Products Address TO Product;");
        }
        
        public override void Down()
        {
        }
    }
}
