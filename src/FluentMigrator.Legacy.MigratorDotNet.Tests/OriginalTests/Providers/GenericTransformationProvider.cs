using System;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Providers
{
	internal class GenericTransformationProvider : TransformationProvider
	{
		public GenericTransformationProvider(IMigrationContext context)
			: base(context)
		{
		}
	}
}