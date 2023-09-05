using System;
using BenchmarkDotNet.Attributes;

namespace sealed_keyword
{
    [MemoryDiagnoser(false)]
    public class BenchMarks
    {
        private readonly BaseClass _baseClasss = new();
        private readonly OpenClass _openClasss = new();
        private readonly ClosedClass _closedClasss = new();

        [Benchmark]
        public void OpenVoid() => _baseClasss.ExampleVoidMethod();

        [Benchmark]
        public void SealedVoid() => _closedClasss.ExampleVoidMethod();



    }
}
