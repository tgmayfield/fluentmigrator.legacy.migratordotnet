using System;
using System.Data;

using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Builders.Delete;
using FluentMigrator.Builders.Rename;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class TableExtensions
	{
		public static void AddTable(this TransformationProvider database, string name, params Column[] columns)
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

		public static void RemoveTable(this TransformationProvider database, string name)
		{
			new DeleteExpressionRoot(database.Context).Table(name);
		}

		public static void RenameTable(this TransformationProvider database, string oldName, string newName)
		{
			new RenameExpressionRoot(database.Context)
				.Table(oldName)
				.To(newName);
		}
	}
}