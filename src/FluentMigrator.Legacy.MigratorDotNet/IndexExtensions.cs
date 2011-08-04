using System;

using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Create.Index;
using FluentMigrator.Builders.Delete;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class IndexExtensions
	{
		public static void AddUniqueConstraint(this ITransformationProvider database, string name, string table, params string[] columns)
		{
			var indexBuilder = new CreateExpressionRoot(database.Context).Index(name);
			var tabledIndexBuilder = indexBuilder.OnTable(table);

			foreach (string column in columns)
			{
				tabledIndexBuilder.OnColumn(column).Ascending();
			}

			tabledIndexBuilder.WithOptions().Unique();
		}

		public static void AddIndex(this ITransformationProvider database, string indexName, string tableName, params string[] columns)
		{
			ICreateIndexOnColumnSyntax builder = new CreateExpressionRoot(database.Context).Index(indexName)
				.OnTable(tableName);

			foreach (var column in columns)
			{
				builder = builder.OnColumn(column).Ascending();
			}
		}

		public static void RemoveIndex(this ITransformationProvider database, string tableName, string indexName)
		{
			new DeleteExpressionRoot(database.Context)
				.Index(indexName)
				.OnTable(tableName);
		}
	}
}