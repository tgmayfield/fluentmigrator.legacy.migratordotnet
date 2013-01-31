using System;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public abstract class MigratorDotNetMigration
		: IMigration
	{
		private readonly object _lock = new object();

		protected TransformationProvider Database { get; private set; }

		public abstract void Up();
		public abstract void Down();

		public virtual void GetUpExpressions(IMigrationContext context)
		{
			lock (_lock)
			{
				ApplicationContext = context.ApplicationContext;
				Database = new TransformationProvider(context);
				Up();
				Database = null;
			}
		}

		public virtual void GetDownExpressions(IMigrationContext context)
		{
			lock (_lock)
			{
				ApplicationContext = context.ApplicationContext;
				Database = new TransformationProvider(context);
				Down();
				Database = null;
			}
		}

		public object ApplicationContext { get; protected set; }
	}
}