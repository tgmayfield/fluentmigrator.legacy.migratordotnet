using System;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests
{
	public class TestMigrationAttribute
		: MigrationAttribute
	{
		public TestMigrationAttribute(long version)
			: base(version)
		{
		}

		public bool Ignore { get; set; }
	}
}