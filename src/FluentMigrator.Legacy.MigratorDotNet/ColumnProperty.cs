using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	[Flags]
	public enum ColumnProperty
	{
		ForeignKey = 0x21,
		Identity = 4,
		Indexed = 0x10,
		None = 0,
		NotNull = 2,
		Null = 1,
		PrimaryKey = 0x62,
		PrimaryKeyWithIdentity = 0x66,
		Unique = 8,
		Unsigned = 0x20
	}
}