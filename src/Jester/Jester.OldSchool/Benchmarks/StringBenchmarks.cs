using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Jester.OldSchool.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringBenchmarks
    {
        private const string FullName = "Philippe Devel";

        [Benchmark]
        public void GetLastName()
        {
            FullName.GetLastWordOfString();
        }

        [Benchmark]
        public void GetLastNameByspan()
        {
            FullName.GetLastWordFromStringBySpan();
        }
    }
}
