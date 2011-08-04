using System;
using System.Collections.Generic;
using System.Reflection;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests
{
	public class Migrator
	{
		public Migrator(ITransformationProvider database, Assembly assembly, bool trace)
		{
			throw new NotImplementedException();
		}

		private readonly List<Type> _migrationsTypes = new List<Type>();
		public List<Type> MigrationsTypes
		{
			get { return _migrationsTypes; }
		}

		public void MigrateTo(long version)
		{
			throw new NotImplementedException();
		}

		public void MigrateToLastVersion()
		{
			throw new NotImplementedException();
		}
	}
}