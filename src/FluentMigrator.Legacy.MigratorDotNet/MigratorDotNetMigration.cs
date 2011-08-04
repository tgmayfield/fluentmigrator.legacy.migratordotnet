using System;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public abstract class MigratorDotNetMigration
		: IMigration
	{
		private readonly object _lock = new object();

		protected ITransformationProvider Database { get; private set; }

		public abstract void Up();
		public abstract void Down();

		public virtual void GetUpExpressions(IMigrationContext context)
		{
			lock (_lock)
			{
				Database = new ITransformationProvider(context);
				Up();
				Database = null;
			}
		}

		public virtual void GetDownExpressions(IMigrationContext context)
		{
			lock (_lock)
			{
				Database = new ITransformationProvider(context);
				Down();
				Database = null;
			}
		}
	}
}