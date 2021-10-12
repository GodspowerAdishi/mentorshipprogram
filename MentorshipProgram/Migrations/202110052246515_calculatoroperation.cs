namespace MentorshipProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calculatoroperation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calculators", "username", c => c.String());
            AddColumn("dbo.Calculators", "fullnames", c => c.String());
            DropColumn("dbo.Calculators", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calculators", "user", c => c.String());
            DropColumn("dbo.Calculators", "fullnames");
            DropColumn("dbo.Calculators", "username");
        }
    }
}
