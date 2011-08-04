using System;
using System.Collections.Generic;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public class TransformationProvider
		: ITransformationProvider
	{
		public TransformationProvider(IMigrationContext context)
		{
			_context = context;
			_logger = new Logger(this);
		}

		private readonly IMigrationContext _context;
		public IMigrationContext Context
		{
			get { return _context; }
		}

		private readonly Logger _logger;
		public Logger Logger
		{
			get { return _logger; }
		}

		private readonly List<long> _appliedMigrations = new List<long>();
		public List<long> AppliedMigrations
		{
			get { return _appliedMigrations; }
		}
	}
}