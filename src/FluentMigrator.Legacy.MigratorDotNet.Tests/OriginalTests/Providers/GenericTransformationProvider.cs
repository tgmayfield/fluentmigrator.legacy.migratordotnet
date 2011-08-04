using System;

using FluentMigrator.Infrastructure;

using NUnit.Framework;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Providers
{
    class GenericTransformationProvider : TransformationProvider
    {
    	public GenericTransformationProvider(IMigrationContext context)
    		: base(context)
    	{
    	}
    }
}