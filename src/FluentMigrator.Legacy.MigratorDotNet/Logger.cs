using System;

namespace FluentMigrator.Legacy.MigratorDotNet
{
	public class Logger
	{
		private readonly ITransformationProvider _database;

		public Logger(ITransformationProvider database)
		{
			_database = database;
		}

		public void Log(string message, params object[] args)
		{
			throw new NotImplementedException();
		}
	}
}