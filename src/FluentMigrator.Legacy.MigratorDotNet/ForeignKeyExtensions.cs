using System;

using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Delete;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ForeignKeyExtensions
	{
		public static void AddForeignKey(this ITransformationProvider database, string name, string sourceTable, string sourceColumn, string destTable, string destColumn)
		{
			database.AddForeignKey(name, sourceColumn, new[] { sourceColumn }, destTable, new[] { destColumn });
		}
		public static void AddForeignKey(this ITransformationProvider database, string name, string sourceTable, string[] sourceColumns, string destTable, string[] destColumns)
		{
			new CreateExpressionRoot(database.Context).ForeignKey(name)
				.FromTable(sourceTable)
				.ForeignColumns(sourceColumns)
				.ToTable(destTable)
				.PrimaryColumns(destColumns);
		}

		public static void RemoveForeignKey(this ITransformationProvider database, string table, string keyName)
		{
			new DeleteExpressionRoot(database.Context).ForeignKey(keyName);
		}
	}
}