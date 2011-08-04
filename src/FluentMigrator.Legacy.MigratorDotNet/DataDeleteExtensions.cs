using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class DataDeleteExtensions
	{
		public static int Delete(this ITransformationProvider database, string table)
		{
			throw new NotImplementedException();
		}

		public static int Delete(this ITransformationProvider database, string table, string[] columns, string[] values)
		{
			throw new NotImplementedException();
		}

		public static int Delete(this ITransformationProvider database, string table, string whereColumn, string whereValue)
		{
			throw new NotImplementedException();
		}
	}
}