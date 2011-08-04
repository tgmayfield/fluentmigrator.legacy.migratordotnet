require 'albacore'

task :default => [:clean, :build, :test]

SOLUTION = "FluentMigrator.Legacy.MigratorDotNet (2010).sln"

task :build => [:update_packages, :build_quick]

msbuild :build_quick do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Build
  msb.solution = SOLUTION
end

msbuild :clean do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Clean
  msb.solution = SOLUTION
end

nunit :test => :build do |nunit|
  nunit.command = Dir.glob('packages/NUnit*/tools/nunit-console.exe').to_a()[0]
  nunit.assemblies "build/FluentMigrator.Legacy.MigratorDotNet.Tests.dll"
  nunit.options '/xml=build\TestResults.xml'
end

task :update_packages do
  sh 'tools/NuGet install -o ./packages src/FluentMigrator.Legacy.MigratorDotNet/packages.config'
  sh 'tools/NuGet install -o ./packages src/FluentMigrator.Legacy.MigratorDotNet.Tests/packages.config'
end

# vim: set tabstop=2 expandtab:
