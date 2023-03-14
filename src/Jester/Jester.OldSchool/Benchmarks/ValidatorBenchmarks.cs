using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jester.OldSchool.Validators;

namespace Jester.OldSchool.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ValidatorBenchmarks
    {
        private static UrlValidator _urlValidator = new UrlValidator();
        private static UrlValidatorNew _urlValidatorNew = new UrlValidatorNew();

        [Params("https://www.google.com", "google")]
        public string url = string.Empty;

        [Benchmark]
        public bool IsOldSkool() => _urlValidator.IsMatch(url);

        [Benchmark]
        public bool IsNewSkool() => _urlValidatorNew.IsMatch(url);
    }
}
