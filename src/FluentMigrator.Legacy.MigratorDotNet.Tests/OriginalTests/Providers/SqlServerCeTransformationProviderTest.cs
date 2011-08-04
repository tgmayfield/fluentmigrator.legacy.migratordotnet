#region License
//The contents of this file are subject to the Mozilla Public License
//Version 1.1 (the "License"); you may not use this file except in
//compliance with the License. You may obtain a copy of the License at
//http://www.mozilla.org/MPL/
//Software distributed under the License is distributed on an "AS IS"
//basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//License for the specific language governing rights and limitations
//under the License.
#endregion

using System;

using NUnit.Framework;

namespace FluentMigrator.Legacy.MigratorDotNet.OriginalTests.Providers
{
	[TestFixture, Category("SqlServerCe")]
	public class SqlServerCeTransformationProviderTest : TransformationProviderConstraintBase
	{
		[SetUp]
		public void SetUp()
		{
			throw new NotImplementedException("Need to configure a SQL Server CE connection");

			AddDefaultTable();
		}

		// [Test,Ignore("SqlServerCe doesn't support check constraints")]
		public override void CanAddCheckConstraint()
		{
		}

		// [Test,Ignore("SqlServerCe doesn't support table renaming")]
		// see: http://www.pocketpcdn.com/articles/articles.php?&atb.set(c_id)=74&atb.set(a_id)=8145&atb.perform(details)=&
		public override void RenameTableThatExists()
		{
		}
	}
}