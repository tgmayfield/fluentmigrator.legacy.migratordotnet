using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public static class ProviderTransactionExtensions
	{
		public static void Commit(this ITransformationProvider database)
		{
			throw new NotImplementedException();
		}
		public static void RollBack(this ITransformationProvider database)
		{
			throw new NotImplementedException();
		}
	}
}