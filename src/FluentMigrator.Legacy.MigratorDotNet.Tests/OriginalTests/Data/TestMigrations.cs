using System;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Data
{
    [TestMigration(1)]
    public class FirstTestMigration : Migration
    {
        override public void Up()
        {
        }
        override public void Down()
        {
        }
    }

	[TestMigration(2)]
    public class SecondTestMigration : MigratorDotNetMigration
    {
    	public override void Up()
    	{
    	}

    	public override void Down()
    	{
    	}
    }
}