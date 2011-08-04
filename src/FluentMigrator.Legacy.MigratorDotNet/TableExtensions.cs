using System;
using System.Collections.Generic;
using System.Data;

using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Builders.Delete;
using FluentMigrator.Builders.Rename;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class TableExtensions
	{
		public static void AddTable(this ITransformationProvider database, string name, string engine, params Column[] columns)
		{
			throw new NotImplementedException();
		}
		public static void AddTable(this ITransformationProvider database, string name, params Column[] columns)
		{
			var tableBuilder = new CreateExpressionRoot(database.Context).Table(name);

			foreach (var column in columns)
			{
				var builder = tableBuilder.WithColumn(column.Name, column.Type, column.Size);
				ColumnExtensions.ApplyColumnOptions(builder, column.ColumnProperty, column.DefaultValue);
			}
		}

		public static ICreateTableColumnOptionOrWithColumnSyntax WithColumn(this ICreateTableWithColumnOrSchemaSyntax tableBuilder, string name, DbType dbType, int size)
		{
			return ColumnExtensions.GetTypedColumn(tableBuilder.WithColumn(name), dbType, size);
		}

		public static void RemoveTable(this ITransformationProvider database, string name)
		{
			new DeleteExpressionRoot(database.Context).Table(name);
		}

		public static void RenameTable(this ITransformationProvider database, string oldName, string newName)
		{
			new RenameExpressionRoot(database.Context)
				.Table(oldName)
				.To(newName);
		}

		public static bool TableExists(this ITransformationProvider database, string name)
		{
			throw new NotImplementedException();
		}

		public static string[] GetTables(this ITransformationProvider database)
		{
			throw new NotImplementedException();
		}
	}
}