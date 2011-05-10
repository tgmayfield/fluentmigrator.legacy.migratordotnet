using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ColumnPropertyExtensions
	{
		public static bool IsSelected(this ColumnProperty property, ColumnProperty test)
		{
			return (property & test) == test;
		}
	}
}