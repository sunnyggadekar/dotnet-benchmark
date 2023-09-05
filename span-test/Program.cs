using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace span_test
{
    class Program
    {

        static void Main()
        {
            //var date = DateSeperated(_dateAsString);
            //var date = DateSeperatedSpan();

            //Console.WriteLine(date);

            BenchmarkRunner.Run<Benchy>();

        }
    }

    [MemoryDiagnoser]
    public class Benchy
    {
        public static readonly string dateAsString = "18 02 2023";

        [Benchmark]
        public (int day, int month, int year) DateSeperated()
        {
            var dayAsString = dateAsString.Substring(0, 2);
            var day = int.Parse(dayAsString);

            var monthAsString = dateAsString.Substring(3, 2);
            var month = int.Parse(monthAsString);

            var yearAsString = dateAsString.Substring(6, 4);
            var year = int.Parse(yearAsString);

            return (day, month, year);
        }

        [Benchmark]
        public (int day, int month, int year) DateSeperatedSpan()
        {
            ReadOnlySpan<char> dateAsSpan = dateAsString;
            var dayAsString = dateAsSpan.Slice(0, 2);
            var day = int.Parse(dayAsString);

            var monthAsString = dateAsSpan.Slice(3, 2);
            var month = int.Parse(monthAsString);

            var yearAsString = dateAsSpan.Slice(6, 4);
            var year = int.Parse(yearAsString);

            return (day, month, year);
        }
    }
}
