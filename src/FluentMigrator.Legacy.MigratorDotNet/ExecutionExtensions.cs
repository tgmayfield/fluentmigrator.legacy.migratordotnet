using System;
using System.Data;

using FluentMigrator.Builders.Execute;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ExecutionExtensions
	{
		public static void ExecuteNonQuery(this ITransformationProvider database, string sql, params object[] args)
		{
			sql = string.Format(sql, args);
			database.ExecuteNonQuery(sql);
		}
		public static void ExecuteNonQuery(this ITransformationProvider database, string sql)
		{
			new ExecuteExpressionRoot(database.Context)
				.Sql(sql);
		}
		public static void Execute(this ITransformationProvider database, Action<IDbConnection, IDbTransaction> action)
		{
			new ExecuteExpressionRoot(database.Context)
				.WithConnection(action);
		}
	}
}