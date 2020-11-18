namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordsToCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '01/01/1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
