using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

using static Benchmarks.Program;

namespace Benchmarks
{
	public partial class Benchmarks
	{
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_NoInlining() {
			Structs all = default;
			ref var location = ref data[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var end = ref NoInlining.TryReadGeneric(ref location, ref all.A);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.B);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.C);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.D);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.E);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.F);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.G);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.H);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.I);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.J);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.K);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.L);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.M);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.N);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.O);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.P);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.Q);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.R);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.S);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.T);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.U);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.V);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.W);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.X);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.Y);
				end = ref NoInlining.TryReadGeneric(ref location, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_FullInlining() {
			Structs all = default;
			ref var location = ref data[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var end = ref FullInlining.TryReadGeneric(ref location, ref all.A);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.B);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.C);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.D);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.E);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.F);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.G);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.H);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.I);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.J);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.K);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.L);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.M);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.N);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.O);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.P);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.Q);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.R);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.S);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.T);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.U);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.V);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.W);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.X);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.Y);
				end = ref FullInlining.TryReadGeneric(ref location, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_InlineFieldReads() {
			Structs all = default;
			ref var location = ref data[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.A);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.B);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.C);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.D);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.E);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.F);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.G);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.H);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.I);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.J);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.K);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.L);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.M);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.N);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.O);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.P);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.Q);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.R);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.S);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.T);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.U);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.V);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.W);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.X);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.Y);
				end = ref InlineFieldReads.TryReadGeneric(ref location, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_InlineStructReads() {
			Structs all = default;
			ref var location = ref data[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var end = ref InlineStructReads.TryReadGeneric(ref location, ref all.A);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.B);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.C);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.D);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.E);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.F);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.G);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.H);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.I);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.J);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.K);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.L);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.M);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.N);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.O);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.P);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.Q);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.R);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.S);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.T);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.U);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.V);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.W);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.X);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.Y);
				end = ref InlineStructReads.TryReadGeneric(ref location, ref all.Z);
#if TEST
				if (end != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}

		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_ManualFieldForField() {
			Structs all = default;
			ref var location = ref data[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var cursor = ref location;

				all.A.a = Unsafe.As<byte, uint>(ref cursor);
				all.B.b = Unsafe.As<byte, ushort>(ref cursor);

				cursor = ref location;

				all.C.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.C.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.C.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.D.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.D.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.D.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.E.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.E.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.E.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.F.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.F.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.F.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.G.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.G.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.G.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.H.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.H.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.H.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.I.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.I.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.I.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.J.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.J.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.J.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.K.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.K.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.K.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.L.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.L.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.L.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.M.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.M.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.M.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.N.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.N.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.N.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.O.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.O.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.O.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.P.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.P.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.P.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.Q.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.Q.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.Q.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.R.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.R.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.R.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.S.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.S.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.S.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.T.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.T.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.T.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.U.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.U.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.U.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.V.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.V.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.V.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.W.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.W.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.W.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.X.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.X.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.X.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.Y.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.Y.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.Y.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));

				cursor = ref location;

				all.Z.u4 = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.Z.u2 = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.Z.u1 = cursor;
				cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
#if TEST
				if (cursor != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}
		[Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
		public Structs FromByteRef_ManualFieldForField_BigData() {
			Structs all = default;
			ref var location = ref bigdata[0];
			for (var i = 0; i < OperationsPerInvoke; i++) {
				ref var cursor = ref location;

				all.A.a = Unsafe.As<byte, uint>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(uint));

				all.B.b = Unsafe.As<byte, ushort>(ref cursor);
				cursor = ref Unsafe.Add(ref cursor, sizeof(ushort));

				all.C.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.C.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.C.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.D.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.D.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.D.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.E.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.E.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.E.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.F.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.F.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.F.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.G.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.G.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.G.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.H.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.H.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.H.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.I.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.I.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.I.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.J.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.J.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.J.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.K.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.K.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.K.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.L.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.L.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.L.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.M.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.M.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.M.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.N.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.N.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.N.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.O.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.O.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.O.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.P.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.P.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.P.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.Q.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.Q.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.Q.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.R.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.R.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.R.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.S.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.S.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.S.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.T.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.T.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.T.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.U.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.U.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.U.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.V.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.V.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.V.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.W.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.W.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.W.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.X.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.X.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.X.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.Y.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.Y.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.Y.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
				all.Z.u4 = Unsafe.As<byte, uint>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(uint)); all.Z.u2 = Unsafe.As<byte, ushort>(ref cursor); cursor = ref Unsafe.Add(ref cursor, sizeof(ushort)); all.Z.u1 = cursor; cursor = ref Unsafe.Add(ref cursor, sizeof(byte));
#if TEST
				if (cursor != EndOfStreamMarker) throw new InvalidOperationException();
#endif
			}
			return all;
		}
	}
}
