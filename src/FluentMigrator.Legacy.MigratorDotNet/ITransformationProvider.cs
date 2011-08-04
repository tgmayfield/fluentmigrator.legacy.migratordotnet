using System;
using System.Collections.Generic;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public interface ITransformationProvider
	{
		IMigrationContext Context { get; }
		Logger Logger { get; }

		List<long> AppliedMigrations { get; }
	}
}