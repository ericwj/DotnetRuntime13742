using System;
using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;
using static Benchmarks.Program;

namespace Benchmarks
{
	public partial class Benchmarks
	{
		#region Issue #13742
		private static class NonGeneric
		{
			public static bool TryRead(ref A a, uint from) {
				a = new A { a = from };
				return true;
			}
			public static bool TryRead(ref B b, uint from) {
				b = new B { b = unchecked((ushort)from) };
				return true;
			}
		}
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryRead<T>(ref T t, uint from) {
			if (typeof(T) == typeof(A)) return NonGeneric.TryRead(ref Unsafe.As<T, A>(ref t), from);
			else if (typeof(T) == typeof(B)) return NonGeneric.TryRead(ref Unsafe.As<T, B>(ref t), from);
			else throw new InvalidCastException();
		}
#if SKIP
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public uint PreviousSample() {
			var result = 0u;
			A a = default;
			B b = default;
			for (var u = 0u; u < OperationsPerInvoke; u++) {
				if (0 == (u & 1)) {
					TryRead(ref a, u);
					result += a.a;
				} else {
					TryRead(ref b, u);
					result += b.b;
				}
			}
			return result;
		}
#endif
		#endregion
	}
}
