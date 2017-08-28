namespace ST.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ActivationCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ActivationCode");
        }
    }
}
