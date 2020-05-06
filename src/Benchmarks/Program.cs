using System;

using BenchmarkDotNet.Running;

namespace Benchmarks
{
	internal class Program
	{
		public const int OperationsPerInvoke = 529 * 529;
		private static void Main(string[] args) {
			BenchmarkRunner.Run<Benchmarks>();
		}
	}
}
