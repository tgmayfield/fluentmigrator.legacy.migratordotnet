using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class MigrationAppliedExtensions
	{
		public static bool MigrationApplied(this ITransformationProvider database, long version)
		{
			throw new NotImplementedException();
		}
	}
}