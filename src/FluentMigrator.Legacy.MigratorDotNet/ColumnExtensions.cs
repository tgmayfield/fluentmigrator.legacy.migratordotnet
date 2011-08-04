using System;
using System.Data;

using FluentMigrator.Builders;
using FluentMigrator.Builders.Alter;
using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Delete;
using FluentMigrator.Builders.Rename;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ColumnExtensions
	{
		public static void AddColumn(this ITransformationProvider database, string table, Column column)
		{
			var columnBuilder = new CreateExpressionRoot(database.Context)
				.Column(column.Name)
				.OnTable(table);

			var typed = GetTypedColumn(columnBuilder, column.Type, column.Size);
			ApplyColumnOptions(typed, column.ColumnProperty, column.DefaultValue);
		}
		public static void RemoveColumn(this ITransformationProvider database, string table, string column)
		{
			new DeleteExpressionRoot(database.Context)
				.Column(column)
				.FromTable(table);
		}

		public static void ChangeColumn(this ITransformationProvider database, string table, Column column)
		{
			var columnBuilder = new AlterExpressionRoot(database.Context)
				.Column(column.Name)
				.OnTable(table);

			var typed = GetTypedColumn(columnBuilder, column.Type, column.Size);
			ApplyColumnOptions(typed, column.ColumnProperty, column.DefaultValue);
		}

		public static void RenameColumn(this ITransformationProvider database, string table, string oldName, string newName)
		{
			new RenameExpressionRoot(database.Context)
				.Column(oldName)
				.OnTable(table)
				.To(newName);
		}

		public static TNext GetTypedColumn<TNext>(IColumnTypeSyntax<TNext> column, DbType dbType, int size)
			where TNext : IFluentSyntax
		{
			switch (dbType)
			{
				case DbType.AnsiString:
					return column.AsAnsiString(size);
				case DbType.Binary:
					return column.AsBinary(size);
				case DbType.Byte:
					return column.AsByte();
				case DbType.Boolean:
					return column.AsBoolean();
				case DbType.Currency:
					return column.AsCurrency();
				case DbType.Date:
					return column.AsDate();
				case DbType.DateTime:
					return column.AsDateTime();
				case DbType.Decimal:
					return column.AsDecimal();
				case DbType.Double:
					return column.AsDouble();
				case DbType.Guid:
					return column.AsGuid();
				case DbType.Int16:
					return column.AsInt16();
				case DbType.Int32:
					return column.AsInt32();
				case DbType.Int64:
					return column.AsInt64();
				case DbType.Object:
					throw new NotSupportedException();
				case DbType.SByte:
					throw new NotSupportedException();
				case DbType.Single:
					return column.AsDouble();
				case DbType.String:
					return column.AsString(size);
				case DbType.Time:
					return column.AsTime();
				case DbType.UInt16:
					throw new NotSupportedException();
				case DbType.UInt32:
					throw new NotSupportedException();
				case DbType.UInt64:
					throw new NotSupportedException();
				case DbType.VarNumeric:
					throw new NotSupportedException();
				case DbType.AnsiStringFixedLength:
					return column.AsFixedLengthAnsiString(size);
				case DbType.StringFixedLength:
					return column.AsFixedLengthString(size);
				case DbType.Xml:
					return column.AsXml(size);
				case DbType.DateTime2:
					return column.AsDateTime();
				case DbType.DateTimeOffset:
					throw new NotSupportedException();
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		public static void ApplyColumnOptions<T>(IColumnOptionSyntax<T> builder, ColumnProperty columnProperty, object defaultValue)
			where T : IFluentSyntax
		{
			if (defaultValue != null)
			{
				builder.WithDefaultValue(defaultValue);
			}

			if (columnProperty.IsSelected(ColumnProperty.Identity))
			{
				builder.Identity();
			}
			if (columnProperty.IsSelected(ColumnProperty.PrimaryKey))
			{
				builder.PrimaryKey();
			}
			if (columnProperty.IsSelected(ColumnProperty.Unsigned))
			{
				// Not supported, but is included in PrimaryKeyWithIdentity, and so it can't throw a NotSupportedException
			}
			if (columnProperty.IsSelected(ColumnProperty.Unique))
			{
				builder.Unique();
			}
			if (columnProperty.IsSelected(ColumnProperty.ForeignKey))
			{
				builder.ForeignKey();
			}

			if (columnProperty.IsSelected(ColumnProperty.NotNull))
			{
				builder.NotNullable();
			}
			else
			{
				builder.Nullable();
			}
		}
	}
}
