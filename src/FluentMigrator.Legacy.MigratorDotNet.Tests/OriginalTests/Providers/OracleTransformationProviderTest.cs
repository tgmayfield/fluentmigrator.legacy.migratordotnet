using System;

using NUnit.Framework;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Providers
{
    [TestFixture, Category("Oracle")]
    public class OracleTransformationProviderTest : TransformationProviderConstraintBase
    {
        [SetUp]
        public void SetUp()
        {
			throw new NotImplementedException("Need to configure an Oracle connection");
            AddDefaultTable();
        }
    }
}