using System.Linq;
using System.Runtime.InteropServices;

using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
#if X86
	[Config(typeof(Use32BitCli))]
#endif
	[DisassemblyDiagnoser(maxDepth: 3, printSource: true)]
	public partial class Benchmarks
	{
		public Benchmarks() => bigdata =
			dataA
			.Concat(dataB)
			.Concat(Enumerable
				.Range((int)'C', (int)('Z' - 'B'))
				.Select(i => dataCtoZ)
				.SelectMany(x => x))
			.Concat(eos)
			.ToArray();

		private const byte EndOfStreamMarker = 0xff;
		private readonly byte[] data = new byte[] {
			0xd3, 0xd2, 0xd1, 0xd0,
			0xc1, 0xc0,
			0xb0,
			EndOfStreamMarker
		};
		private readonly byte[] dataA = new byte[] {
			0xa3, 0xa2, 0xa1, 0xa0,
		};
		private readonly byte[] dataB = new byte[] {
			0xb1, 0xb0,
		};
		private readonly byte[] dataCtoZ = new byte[] {
			0xd3, 0xd2, 0xd1, 0xd0,
			0xc1, 0xc0,
			0xb0,
		};
		private readonly byte[] eos = new byte[] { EndOfStreamMarker };
		private readonly byte[] bigdata;
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
