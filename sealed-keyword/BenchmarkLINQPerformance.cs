using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class BenchmarkLINQPerformance
{
    private readonly List<string>
    data = new List<string>();

    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 65; i < 90; i++)
        {
            char c = (char)i;
            data.Add(c.ToString());
        }
    }

    [Benchmark]
    public string SingleOrDefault() => data.SingleOrDefault(x => x.Equals("M"));

    [Benchmark]
    public string FirstOrDefault() => data.FirstOrDefault(x => x.Equals("M"));

    [Benchmark]
    public string First() => data.First(x => x.Equals("M"));

    [Benchmark]
    public string Single() => data.Single(x => x.Equals("M"));
}
