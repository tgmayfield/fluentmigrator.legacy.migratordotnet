using System;

using NUnit.Framework;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Providers
{
    [TestFixture, Category("Postgre")]
    public class PostgreSQLTransformationProviderTest : TransformationProviderConstraintBase
    {
        [SetUp]
        public void SetUp()
        {
			throw new NotImplementedException("Need to configure a PostgreSQL connection");
            AddDefaultTable();
        }
    }
}