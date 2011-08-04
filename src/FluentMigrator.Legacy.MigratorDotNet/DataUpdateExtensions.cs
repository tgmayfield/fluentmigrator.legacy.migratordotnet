using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class DataUpdateExtensions
	{
		public static int Update(this ITransformationProvider database, string table, string[] columns, string[] values)
		{
			throw new NotImplementedException();
		}
		public static int Update(this ITransformationProvider database, string table, string[] columns, string[] values, string where)
		{
			throw new NotImplementedException();
		}
	}
}