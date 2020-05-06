using System;
using System.CodeDom;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using BenchmarkDotNet.Attributes;

using static Benchmarks.Program;

namespace Benchmarks
{
#if X86
	[Config(typeof(Use32BitCli))]
#endif
	[DisassemblyDiagnoser(maxDepth: 3, printSource: true)]
	public partial class Benchmarks
	{

		private const byte EndOfStreamMarker = 0xff;
		private readonly byte[] data = new byte[] {
			0xd3, 0xd2, 0xd1, 0xd0,
			0xc1, 0xc0,
			0xb0,
			EndOfStreamMarker
		};
		private GCHandle pinned;

		[GlobalSetup]
		public void Setup() {
			pinned = GCHandle.Alloc(data, GCHandleType.Pinned);
		}

		[GlobalCleanup]
		public void Cleanup() {
			pinned.Free();
		}
		
	}
}
