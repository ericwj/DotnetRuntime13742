using System;
using System.Buffers.Binary;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using BenchmarkDotNet.Attributes;

using static Benchmarks.Program;

namespace Benchmarks
{
	public partial class Benchmarks
	{
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_NoInlining() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				NoInlining.TryReadGeneric(span, ref all.A);
				NoInlining.TryReadGeneric(span, ref all.B);
				NoInlining.TryReadGeneric(span, ref all.C);
				NoInlining.TryReadGeneric(span, ref all.D);
				NoInlining.TryReadGeneric(span, ref all.E);
				NoInlining.TryReadGeneric(span, ref all.F);
				NoInlining.TryReadGeneric(span, ref all.G);
				NoInlining.TryReadGeneric(span, ref all.H);
				NoInlining.TryReadGeneric(span, ref all.I);
				NoInlining.TryReadGeneric(span, ref all.J);
				NoInlining.TryReadGeneric(span, ref all.K);
				NoInlining.TryReadGeneric(span, ref all.L);
				NoInlining.TryReadGeneric(span, ref all.M);
				NoInlining.TryReadGeneric(span, ref all.N);
				NoInlining.TryReadGeneric(span, ref all.O);
				NoInlining.TryReadGeneric(span, ref all.P);
				NoInlining.TryReadGeneric(span, ref all.Q);
				NoInlining.TryReadGeneric(span, ref all.R);
				NoInlining.TryReadGeneric(span, ref all.S);
				NoInlining.TryReadGeneric(span, ref all.T);
				NoInlining.TryReadGeneric(span, ref all.U);
				NoInlining.TryReadGeneric(span, ref all.V);
				NoInlining.TryReadGeneric(span, ref all.W);
				NoInlining.TryReadGeneric(span, ref all.X);
				NoInlining.TryReadGeneric(span, ref all.Y);
				NoInlining.TryReadGeneric(span, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_FullInlining() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				FullInlining.TryReadGeneric(span, ref all.A);
				FullInlining.TryReadGeneric(span, ref all.B);
				FullInlining.TryReadGeneric(span, ref all.C);
				FullInlining.TryReadGeneric(span, ref all.D);
				FullInlining.TryReadGeneric(span, ref all.E);
				FullInlining.TryReadGeneric(span, ref all.F);
				FullInlining.TryReadGeneric(span, ref all.G);
				FullInlining.TryReadGeneric(span, ref all.H);
				FullInlining.TryReadGeneric(span, ref all.I);
				FullInlining.TryReadGeneric(span, ref all.J);
				FullInlining.TryReadGeneric(span, ref all.K);
				FullInlining.TryReadGeneric(span, ref all.L);
				FullInlining.TryReadGeneric(span, ref all.M);
				FullInlining.TryReadGeneric(span, ref all.N);
				FullInlining.TryReadGeneric(span, ref all.O);
				FullInlining.TryReadGeneric(span, ref all.P);
				FullInlining.TryReadGeneric(span, ref all.Q);
				FullInlining.TryReadGeneric(span, ref all.R);
				FullInlining.TryReadGeneric(span, ref all.S);
				FullInlining.TryReadGeneric(span, ref all.T);
				FullInlining.TryReadGeneric(span, ref all.U);
				FullInlining.TryReadGeneric(span, ref all.V);
				FullInlining.TryReadGeneric(span, ref all.W);
				FullInlining.TryReadGeneric(span, ref all.X);
				FullInlining.TryReadGeneric(span, ref all.Y);
				FullInlining.TryReadGeneric(span, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_InlineFieldReads() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				InlineFieldReads.TryReadGeneric(span, ref all.A);
				InlineFieldReads.TryReadGeneric(span, ref all.B);
				InlineFieldReads.TryReadGeneric(span, ref all.C);
				InlineFieldReads.TryReadGeneric(span, ref all.D);
				InlineFieldReads.TryReadGeneric(span, ref all.E);
				InlineFieldReads.TryReadGeneric(span, ref all.F);
				InlineFieldReads.TryReadGeneric(span, ref all.G);
				InlineFieldReads.TryReadGeneric(span, ref all.H);
				InlineFieldReads.TryReadGeneric(span, ref all.I);
				InlineFieldReads.TryReadGeneric(span, ref all.J);
				InlineFieldReads.TryReadGeneric(span, ref all.K);
				InlineFieldReads.TryReadGeneric(span, ref all.L);
				InlineFieldReads.TryReadGeneric(span, ref all.M);
				InlineFieldReads.TryReadGeneric(span, ref all.N);
				InlineFieldReads.TryReadGeneric(span, ref all.O);
				InlineFieldReads.TryReadGeneric(span, ref all.P);
				InlineFieldReads.TryReadGeneric(span, ref all.Q);
				InlineFieldReads.TryReadGeneric(span, ref all.R);
				InlineFieldReads.TryReadGeneric(span, ref all.S);
				InlineFieldReads.TryReadGeneric(span, ref all.T);
				InlineFieldReads.TryReadGeneric(span, ref all.U);
				InlineFieldReads.TryReadGeneric(span, ref all.V);
				InlineFieldReads.TryReadGeneric(span, ref all.W);
				InlineFieldReads.TryReadGeneric(span, ref all.X);
				InlineFieldReads.TryReadGeneric(span, ref all.Y);
				InlineFieldReads.TryReadGeneric(span, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_InlineStructReads() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				InlineStructReads.TryReadGeneric(span, ref all.A);
				InlineStructReads.TryReadGeneric(span, ref all.B);
				InlineStructReads.TryReadGeneric(span, ref all.C);
				InlineStructReads.TryReadGeneric(span, ref all.D);
				InlineStructReads.TryReadGeneric(span, ref all.E);
				InlineStructReads.TryReadGeneric(span, ref all.F);
				InlineStructReads.TryReadGeneric(span, ref all.G);
				InlineStructReads.TryReadGeneric(span, ref all.H);
				InlineStructReads.TryReadGeneric(span, ref all.I);
				InlineStructReads.TryReadGeneric(span, ref all.J);
				InlineStructReads.TryReadGeneric(span, ref all.K);
				InlineStructReads.TryReadGeneric(span, ref all.L);
				InlineStructReads.TryReadGeneric(span, ref all.M);
				InlineStructReads.TryReadGeneric(span, ref all.N);
				InlineStructReads.TryReadGeneric(span, ref all.O);
				InlineStructReads.TryReadGeneric(span, ref all.P);
				InlineStructReads.TryReadGeneric(span, ref all.Q);
				InlineStructReads.TryReadGeneric(span, ref all.R);
				InlineStructReads.TryReadGeneric(span, ref all.S);
				InlineStructReads.TryReadGeneric(span, ref all.T);
				InlineStructReads.TryReadGeneric(span, ref all.U);
				InlineStructReads.TryReadGeneric(span, ref all.V);
				InlineStructReads.TryReadGeneric(span, ref all.W);
				InlineStructReads.TryReadGeneric(span, ref all.X);
				InlineStructReads.TryReadGeneric(span, ref all.Y);
				InlineStructReads.TryReadGeneric(span, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_ManualFieldForField_Progressive() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				var from = span;
				all.A.a = BinaryPrimitives.ReadUInt32LittleEndian(from);
				all.B.b = BinaryPrimitives.ReadUInt16LittleEndian(from);

							 all.C.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.C.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.C.u1 = from[0];
				from = span; all.D.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.D.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.D.u1 = from[0];
				from = span; all.E.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.E.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.E.u1 = from[0];
				from = span; all.F.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.F.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.F.u1 = from[0];
				from = span; all.G.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.G.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.G.u1 = from[0];
				from = span; all.H.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.H.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.H.u1 = from[0];
				from = span; all.I.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.I.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.I.u1 = from[0];
				from = span; all.J.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.J.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.J.u1 = from[0];
				from = span; all.K.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.K.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.K.u1 = from[0];
				from = span; all.L.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.L.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.L.u1 = from[0];
				from = span; all.M.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.M.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.M.u1 = from[0];
				from = span; all.N.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.N.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.N.u1 = from[0];
				from = span; all.O.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.O.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.O.u1 = from[0];
				from = span; all.P.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.P.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.P.u1 = from[0];
				from = span; all.Q.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.Q.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.Q.u1 = from[0];
				from = span; all.R.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.R.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.R.u1 = from[0];
				from = span; all.S.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.S.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.S.u1 = from[0];
				from = span; all.T.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.T.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.T.u1 = from[0];
				from = span; all.U.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.U.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.U.u1 = from[0];
				from = span; all.V.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.V.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.V.u1 = from[0];
				from = span; all.W.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.W.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.W.u1 = from[0];
				from = span; all.X.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.X.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.X.u1 = from[0];
				from = span; all.Y.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.Y.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.Y.u1 = from[0];
				from = span; all.Z.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); from = from.Slice(sizeof(uint)); all.Z.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from); from = from.Slice(sizeof(ushort)); all.Z.u1 = from[0];
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromSpan_ManualFieldForField_NoProgress() {
			Structs all = default;
			var span = data.AsSpan();
			for (var i = 0; i < OperationsPerInvoke; i++) {
				var from = span;
				all.A.a = BinaryPrimitives.ReadUInt32LittleEndian(from);
				all.B.b = BinaryPrimitives.ReadUInt16LittleEndian(from);

				all.C.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.C.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.C.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.D.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.D.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.D.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.E.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.E.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.E.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.F.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.F.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.F.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.G.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.G.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.G.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.H.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.H.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.H.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.I.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.I.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.I.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.J.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.J.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.J.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.K.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.K.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.K.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.L.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.L.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.L.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.M.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.M.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.M.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.N.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.N.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.N.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.O.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.O.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.O.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.P.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.P.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.P.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.Q.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.Q.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.Q.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.R.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.R.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.R.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.S.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.S.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.S.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.T.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.T.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.T.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.U.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.U.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.U.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.V.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.V.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.V.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.W.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.W.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.W.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.X.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.X.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.X.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.Y.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.Y.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.Y.u1 = from[sizeof(uint) + sizeof(ushort)];
				all.Z.u4 = BinaryPrimitives.ReadUInt32LittleEndian(from); all.Z.u2 = BinaryPrimitives.ReadUInt16LittleEndian(from.Slice(sizeof(uint))); all.Z.u1 = from[sizeof(uint) + sizeof(ushort)];
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}
	}
}
