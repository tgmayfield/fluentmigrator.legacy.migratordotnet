using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class PrimaryKeyExtensions
	{
		public static void AddPrimaryKey(this ITransformationProvider database, string name, string table, params string[] columns)
		{
			throw new NotImplementedException();
		}

		public static bool PrimaryKeyExists(this ITransformationProvider database, string table, string name)
		{
			throw new NotImplementedException();
		}
	}
}