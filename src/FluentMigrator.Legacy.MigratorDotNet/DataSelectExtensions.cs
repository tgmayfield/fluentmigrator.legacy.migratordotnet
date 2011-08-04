using System;
using System.Data;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class DataSelectExtensions
	{
		public static IDataReader Select(this ITransformationProvider database, string what, string from)
		{
			return database.Select(what, from, "1=1");
		}

		public static IDataReader Select(this ITransformationProvider database, string what, string from, string where)
		{
			return database.ExecuteQuery(String.Format("SELECT {0} FROM {1} WHERE {2}", what, from, where));
		}

		public static object SelectScalar(this ITransformationProvider database, string what, string from)
		{
			return database.SelectScalar(what, from, "1=1");
		}

		public static object SelectScalar(this ITransformationProvider database, string what, string from, string where)
		{
			return database.ExecuteScalar(String.Format("SELECT {0} FROM {1} WHERE {2}", what, from, where));
		}

		public static IDataReader ExecuteQuery(this ITransformationProvider database, string sql)
		{
			throw new NotImplementedException();
		}

		public static object ExecuteScalar(this ITransformationProvider database, string sql)
		{
			throw new NotImplementedException();
		}
	}
}