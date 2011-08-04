using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ConstraintExtensions
	{
		public static void AddCheckConstraint(this ITransformationProvider database, string name, string table, string constraint)
		{
			database.ExecuteNonQuery("ALTER TABLE [{0}] ADD CONSTRAINT [{1}] CHECK ({2})", table, name, constraint);
		}

		public static void RemoveConstraint(this ITransformationProvider database, string table, string name)
		{
			database.ExecuteNonQuery("ALTER TABLE [{0}] DROP CONSTRAINT [{1}]", table, name);
		}
	}
}