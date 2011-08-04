require 'albacore'
require 'rake/clean'

task :default => [:clean, :build, :test]

SOLUTION = "FluentMigrator.Legacy.MigratorDotNet (2010).sln"

VERSION = "0.1.0.0"

CLEAN.include('build')
CLEAN.include('src/*/bin')
CLEAN.include('src/*/obj')

task :build => [:set_version, :update_packages, :build_quick]

assemblyinfo :set_version do |asm|
  asm.version = VERSION
  asm.product_name = "FluentMigrator.Legacy.MigratorDotNet"
  asm.output_file = "src/SolutionInfo.cs"
end

msbuild :build_quick do |msb|
  msb.properties :configuration => :Release
  msb.targets :Build
  msb.solution = SOLUTION
end

task :test => [:build, :test_quick]
nunit :test_quick do |nunit|
  nunit.command = Dir.glob('packages/NUnit*/tools/nunit-console.exe').to_a()[0]
  nunit.assemblies "build/FluentMigrator.Legacy.MigratorDotNet.Tests.dll"
  nunit.options '/xml=build\TestResults.xml'
end

task :update_packages do
  sh 'tools/NuGet install -o ./packages src/FluentMigrator.Legacy.MigratorDotNet/packages.config'
  sh 'tools/NuGet install -o ./packages src/FluentMigrator.Legacy.MigratorDotNet.Tests/packages.config'
end

task :publish => [:generate_nuspec, :generate_nupkg, :push_nupkg]

nuspec :generate_nuspec do |nuspec|
  nuspec.id = "FluentMigrator.Legacy.MigratorDotNet"
  nuspec.version = VERSION
  nuspec.file_version = VERSION
  nuspec.authors = "Thomas G Mayfield"
  nuspec.title = "Legacy Migrator.NET support for FluentMigrator"
  nuspec.description = "Use FluentMigrator with old Migrator.NET migrations"
  nuspec.language = "en-US"
  nuspec.projectUrl = "https://github.com/tgmayfield/fluentmigrator.legacy.migratordotnet"
  nuspec.dependency "FluentMigrator", "0.9.2.0"
  nuspec.working_directory = "build/"
  nuspec.output_file = "FluentMigrator.Legacy.MigratorDotNet.nuspec"

  nuspec.file "FluentMigrator.Legacy.MigratorDotNet.dll", "lib/net35"
  nuspec.file "FluentMigrator.Legacy.MigratorDotNet.pdb", "lib/net35"
end

nugetpack :generate_nupkg do |nuget|
  nuget.command = "tools/nuget.exe"
  nuget.nuspec = "build/FluentMigrator.Legacy.MigratorDotNet.nuspec"
  nuget.output = "build/"
end

nugetpush :push_nupkg do |nuget|
  nuget.command = "tools/nuget.exe"
  nuget.package = "build/FluentMigrator.Legacy.MigratorDotNet.#{VERSION}.nupkg"
end

# vim: set tabstop=2 expandtab:
