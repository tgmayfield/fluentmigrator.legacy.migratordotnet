require 'albacore'

task :default => [:clean, :build, :test]

SOLUTION = "FluentMigrator.Legacy.MigratorDotNet (2010).sln"

msbuild :build do |msb|
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
  nunit.command = "tools/NUnit/nunit-console.exe"
  nunit.assemblies "build/FluentMigrator.Legacy.MigratorDotNet.Tests.dll"
  nunit.options '/xml=build\TestResults.xml'
end

# vim: set tabstop=2 expandtab:
