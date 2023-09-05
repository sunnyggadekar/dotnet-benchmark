using System;
using BenchmarkDotNet.Running;

namespace sealed_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkLINQPerformance>();
        }
    }
}
