 
#define INLINE_STRUCTREADS 
#define INLINE_FIELDREADS 
using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Benchmarks
{
	#if INLINE_STRUCTREADS
		#if INLINE_FIELDREADS
			/// <summary>Field and struct read methods inlined</summary>
			public static class FullInlining
		#else
			/// <summary>Only field reads inlined</summary>
			public static class InlineStructReads
		#endif
	#else
		#if INLINE_FIELDREADS
			/// <summary>Only struct reads inlined</summary>
			public static class InlineFieldReads
		#else
			/// <summary>Nothing inlined</summary>
			public static class NoInlining
		#endif
	#endif
	{
		#if INLINE_FIELDREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte ReadByte(ref byte location, out byte result) {
			result = location;
			return ref Unsafe.Add(ref location, 1);
		}
		#if INLINE_FIELDREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte ReadWord(ref byte location, out ushort result) {
			result = Unsafe.As<byte, ushort>(ref location);
			return ref Unsafe.Add(ref location, 2);
		}
		#if INLINE_FIELDREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte ReadDWord(ref byte location, out uint result) {
			result = Unsafe.As<byte, uint>(ref location);
			return ref Unsafe.Add(ref location, 4);
		}
		#if INLINE_FIELDREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte ReadField<T>(ref byte location, out T result)
			where T : unmanaged
		{
			if (Unsafe.SizeOf<T>() == sizeof(uint)) {
				result = Unsafe.As<uint, T>(ref Unsafe.As<byte, uint>(ref location));
				return ref Unsafe.Add(ref location, sizeof(uint));
			} else if (Unsafe.SizeOf<T>() == sizeof(ushort)) {
				result = Unsafe.As<ushort, T>(ref Unsafe.As<byte, ushort>(ref location));
				return ref Unsafe.Add(ref location, sizeof(ushort));
			} else if (Unsafe.SizeOf<T>() == sizeof(byte)) {
				result = Unsafe.As<byte, T>(ref location);
				return ref Unsafe.Add(ref location, sizeof(byte));
			} else
				throw new InvalidCastException();
		}

		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte UnsafeReadTyped(ref byte location, out C result) {
			ref var cursor = ref location;
			cursor = ref ReadDWord(ref cursor, out result.u4);
			cursor = ref ReadWord(ref cursor, out result.u2);
			cursor = ref ReadByte(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out A result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.a);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out B result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.b);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out C result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryReadGeneric<T>(ref byte location, ref T result) {
				 if (typeof(T) == typeof(A))	return ref TryRead(ref location, out Unsafe.As<T, A>(ref result));
			else if (typeof(T) == typeof(B))	return ref TryRead(ref location, out Unsafe.As<T, B>(ref result));
			else if (typeof(T) == typeof(C))	return ref TryRead(ref location, out Unsafe.As<T, C>(ref result));
			else if (typeof(T) == typeof(D))	return ref TryRead(ref location, out Unsafe.As<T, D>(ref result));
			else if (typeof(T) == typeof(E))	return ref TryRead(ref location, out Unsafe.As<T, E>(ref result));
			else if (typeof(T) == typeof(F))	return ref TryRead(ref location, out Unsafe.As<T, F>(ref result));
			else if (typeof(T) == typeof(G))	return ref TryRead(ref location, out Unsafe.As<T, G>(ref result));
			else if (typeof(T) == typeof(H))	return ref TryRead(ref location, out Unsafe.As<T, H>(ref result));
			else if (typeof(T) == typeof(I))	return ref TryRead(ref location, out Unsafe.As<T, I>(ref result));
			else if (typeof(T) == typeof(J))	return ref TryRead(ref location, out Unsafe.As<T, J>(ref result));
			else if (typeof(T) == typeof(K))	return ref TryRead(ref location, out Unsafe.As<T, K>(ref result));
			else if (typeof(T) == typeof(L))	return ref TryRead(ref location, out Unsafe.As<T, L>(ref result));
			else if (typeof(T) == typeof(M))	return ref TryRead(ref location, out Unsafe.As<T, M>(ref result));
			else if (typeof(T) == typeof(N))	return ref TryRead(ref location, out Unsafe.As<T, N>(ref result));
			else if (typeof(T) == typeof(O))	return ref TryRead(ref location, out Unsafe.As<T, O>(ref result));
			else if (typeof(T) == typeof(P))	return ref TryRead(ref location, out Unsafe.As<T, P>(ref result));
			else if (typeof(T) == typeof(Q))	return ref TryRead(ref location, out Unsafe.As<T, Q>(ref result));
			else if (typeof(T) == typeof(R))	return ref TryRead(ref location, out Unsafe.As<T, R>(ref result));
			else if (typeof(T) == typeof(S))	return ref TryRead(ref location, out Unsafe.As<T, S>(ref result));
			else if (typeof(T) == typeof(global::Benchmarks.T))	return ref TryRead(ref location, out Unsafe.As<T, global::Benchmarks.T>(ref result));
			else if (typeof(T) == typeof(U))	return ref TryRead(ref location, out Unsafe.As<T, U>(ref result));
			else if (typeof(T) == typeof(V))	return ref TryRead(ref location, out Unsafe.As<T, V>(ref result));
			else if (typeof(T) == typeof(W))	return ref TryRead(ref location, out Unsafe.As<T, W>(ref result));
			else if (typeof(T) == typeof(X))	return ref TryRead(ref location, out Unsafe.As<T, X>(ref result));
			else if (typeof(T) == typeof(Y))	return ref TryRead(ref location, out Unsafe.As<T, Y>(ref result));
			else if (typeof(T) == typeof(Z))	return ref TryRead(ref location, out Unsafe.As<T, Z>(ref result));
			else throw new InvalidCastException();
		}
		#region From Span<byte>

		#if INLINE_FIELDREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> ReadField<T>(Span<byte> location, out T result)
			where T : unmanaged
		{
			if (Unsafe.SizeOf<T>() == sizeof(uint)) {
				var value = BinaryPrimitives.ReadUInt32LittleEndian(location);
				result = Unsafe.As<uint, T>(ref value);
				return location.Slice(sizeof(uint));
			} else if (Unsafe.SizeOf<T>() == sizeof(ushort)) {
				var value = BinaryPrimitives.ReadUInt16LittleEndian(location);
				result = Unsafe.As<ushort, T>(ref value);
				return location.Slice(sizeof(ushort));
			} else if (Unsafe.SizeOf<T>() == sizeof(byte)) {
				result = Unsafe.As<byte, T>(ref location[0]);
				return location.Slice(sizeof(byte));
			} else
				throw new InvalidCastException();
		}

		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out A result) {
			var cursor = location;
			cursor = ReadField(cursor, out result.a);
			return cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out B result) {
			var cursor = location;
			cursor = ReadField(cursor, out result.b);
			return cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out C result) {
			var cursor = location;
			cursor = ReadField(cursor, out result.u4);
			cursor = ReadField(cursor, out result.u2);
			cursor = ReadField(cursor, out result.u1);
			return cursor;
		}

		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryReadGeneric<T>(Span<byte> location, ref T result) {
				 if (typeof(T) == typeof(A))	return TryRead(location, out Unsafe.As<T, A>(ref result));
			else if (typeof(T) == typeof(B))	return TryRead(location, out Unsafe.As<T, B>(ref result));
			else if (typeof(T) == typeof(C))	return TryRead(location, out Unsafe.As<T, C>(ref result));
			else if (typeof(T) == typeof(D))	return TryRead(location, out Unsafe.As<T, D>(ref result));
			else if (typeof(T) == typeof(E))	return TryRead(location, out Unsafe.As<T, E>(ref result));
			else if (typeof(T) == typeof(F))	return TryRead(location, out Unsafe.As<T, F>(ref result));
			else if (typeof(T) == typeof(G))	return TryRead(location, out Unsafe.As<T, G>(ref result));
			else if (typeof(T) == typeof(H))	return TryRead(location, out Unsafe.As<T, H>(ref result));
			else if (typeof(T) == typeof(I))	return TryRead(location, out Unsafe.As<T, I>(ref result));
			else if (typeof(T) == typeof(J))	return TryRead(location, out Unsafe.As<T, J>(ref result));
			else if (typeof(T) == typeof(K))	return TryRead(location, out Unsafe.As<T, K>(ref result));
			else if (typeof(T) == typeof(L))	return TryRead(location, out Unsafe.As<T, L>(ref result));
			else if (typeof(T) == typeof(M))	return TryRead(location, out Unsafe.As<T, M>(ref result));
			else if (typeof(T) == typeof(N))	return TryRead(location, out Unsafe.As<T, N>(ref result));
			else if (typeof(T) == typeof(O))	return TryRead(location, out Unsafe.As<T, O>(ref result));
			else if (typeof(T) == typeof(P))	return TryRead(location, out Unsafe.As<T, P>(ref result));
			else if (typeof(T) == typeof(Q))	return TryRead(location, out Unsafe.As<T, Q>(ref result));
			else if (typeof(T) == typeof(R))	return TryRead(location, out Unsafe.As<T, R>(ref result));
			else if (typeof(T) == typeof(S))	return TryRead(location, out Unsafe.As<T, S>(ref result));
			else if (typeof(T) == typeof(global::Benchmarks.T))	return TryRead(location, out Unsafe.As<T, global::Benchmarks.T>(ref result));
			else if (typeof(T) == typeof(U))	return TryRead(location, out Unsafe.As<T, U>(ref result));
			else if (typeof(T) == typeof(V))	return TryRead(location, out Unsafe.As<T, V>(ref result));
			else if (typeof(T) == typeof(W))	return TryRead(location, out Unsafe.As<T, W>(ref result));
			else if (typeof(T) == typeof(X))	return TryRead(location, out Unsafe.As<T, X>(ref result));
			else if (typeof(T) == typeof(Y))	return TryRead(location, out Unsafe.As<T, Y>(ref result));
			else if (typeof(T) == typeof(Z))	return TryRead(location, out Unsafe.As<T, Z>(ref result));
			else throw new InvalidCastException();
		}
		#endregion

		#region Structs D-Z from ref byte
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out D result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out E result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out F result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out G result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out H result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out I result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out J result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out K result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out L result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out M result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out N result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out O result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out P result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out Q result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out R result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out S result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out T result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out U result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out V result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out W result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out X result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out Y result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static ref byte TryRead(ref byte location, out Z result) {
			ref var cursor = ref location;
			cursor = ref ReadField(ref cursor, out result.u4);
			cursor = ref ReadField(ref cursor, out result.u2);
			cursor = ref ReadField(ref cursor, out result.u1);
			return ref cursor;
		}
		#endregion

		#region Structs D-Z from Span<byte>
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out D result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out E result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out F result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out G result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out H result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out I result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out J result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out K result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out L result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out M result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out N result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out O result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out P result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out Q result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out R result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out S result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out T result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out U result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out V result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out W result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out X result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out Y result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#if INLINE_STRUCTREADS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		#endif
		public static Span<byte> TryRead(Span<byte> location, out Z result) { var cursor = location; cursor = ReadField(cursor, out result.u4); cursor = ReadField(cursor, out result.u2); cursor = ReadField(cursor, out result.u1); return cursor; }
		#endregion
	}
}
