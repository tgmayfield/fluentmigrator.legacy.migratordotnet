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
            string constr = ConfigurationManager.AppSettings["OracleConnectionString"];
            if (constr == null)
                throw new ArgumentNullException("OracleConnectionString", "No config file");
            _provider = new OracleTransformationProvider(new OracleDialect(), constr);
            _provider.BeginTransaction();

            AddDefaultTable();
        }
    }
}