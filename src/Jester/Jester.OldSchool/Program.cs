using BenchmarkDotNet.Running;
using Jester.OldSchool.Benchmarks;
using Jester.OldSchool.Models;
using Jester.OldSchool.Services;

var author = new Person()
{
    Name = "Philippe",
    LinkedInUrl = "https://www.google.be",
    Email = "philippe.devel@gmail.com"
};

var j = new Joke()
{
    Setup = "What?",
    Punchline = "haha"
};
j.Punchline = "hahaha";
j.Is12Plus = true;
j.Is18Plus = false;
j.Author = author;
j.Language = "Mandarin";
j.Created = DateTime.Now;

//BenchmarkRunner.Run<ValidatorBenchmarks>();

DadJokesService service = new DadJokesService();
var response = service.GetJokes();
Console.WriteLine(response.Count());
