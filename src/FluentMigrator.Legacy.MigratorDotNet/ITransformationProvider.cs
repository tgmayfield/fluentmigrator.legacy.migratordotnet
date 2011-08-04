using System;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public interface ITransformationProvider
	{
		IMigrationContext Context { get; }
	}
}