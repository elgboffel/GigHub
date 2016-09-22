namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledToGig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gigs", "IsCanceled", c => c.Int(nullable: false));
        }
    }
}
