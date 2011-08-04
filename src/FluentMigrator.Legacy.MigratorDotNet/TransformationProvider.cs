using System;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public class TransformationProvider
		: ITransformationProvider
	{
		public TransformationProvider(IMigrationContext context)
		{
			_context = context;
		}

		private readonly IMigrationContext _context;
		public IMigrationContext Context
		{
			get { return _context; }
		}
	}
}