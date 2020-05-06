using System;

using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Toolchains.DotNetCli;

namespace IL.PE.Clr.Benchmarks.Configurations
{
	public class Use32BitCli : ManualConfig
	{
		public Use32BitCli() {
			// .NET
			//			if (Environment.Is64BitOperatingSystem)
			//			{
			//				Add(Job.RyuJitX64.With(CsProjClassicNetToolchain.Net47).WithId(".NET 4.7 x86_64"));
			//			}
			//			Add(Job.LegacyJitX86.With(CsProjClassicNetToolchain.Net47).WithId(".NET 4.7 x86"));

			// .NET Core
			if (Environment.Is64BitOperatingSystem) {
				//				var dotnetCli = NetCoreAppSettings
				//					.NetCoreApp30
				//					.WithCustomDotNetCliPath(@"C:\Program Files\dotnet\dotnet.exe", "64 bit cli");
				//				Add(Job.Core.With(Platform.X64).With(CsProjCoreToolchain.From(dotnetCli)).WithId("64 bit cli"));

				var dotnetCli32bit = NetCoreAppSettings
					.NetCoreApp30
					.WithCustomDotNetCliPath(@"C:\Program Files (x86)\dotnet\dotnet.exe", "32 bit cli");
				AddJob(Job.Default.WithRuntime(CoreRuntime.Core30)
					.WithToolchain(CsProjCoreToolchain.From(dotnetCli32bit)).WithId("32 bit cli"));
			} else {
				AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp30));
			}

			AddLogger(new ConsoleLogger());
			AddExporter(DefaultExporters.Plain);
			AddColumnProvider(DefaultColumnProviders.Instance);
		}
	}
}
