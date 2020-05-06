
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Toolchains.DotNetCli;

namespace IL.PE.Clr.Benchmarks.Configurations
{
	public class X86 : ManualConfig
	{
		public X86() {
			var dotnetCli32bit = NetCoreAppSettings
					.NetCoreApp20
					.WithCustomDotNetCliPath(@"C:\Program Files (x86)\dotnet\dotnet.exe", "32 bit cli");
			AddJob(Job.Default
				.WithPlatform(Platform.X86)
				.WithToolchain(CsProjCoreToolchain.NetCoreApp30));

			//Add(DisassemblyDiagnoser.Create(new DisassemblyDiagnoserConfig(
			//    printAsm: true, printIL: true, printPrologAndEpilog: true, recursiveDepth: 3)));
		}
	}
}
