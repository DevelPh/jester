using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Jester.OldSchool.Models;

namespace Jester.OldSchool.Services
{
    file record ResponseJoke
    {
        public int id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public bool is12Plus { get; set; }
        public bool is18Plus { get; set; }
        public string created { get; set; }
        public string language { get; set; }
        public string type { get; set; }
        public ResponsePerson author { get; set; }
    }
    
    public class DadJokesService
    {

        public Joke GetJoke()
        {
            //var punchline = "punch \n punch";
            //var punchline = $"punch {Environment.NewLine} punch";
            // raw string literal
            var punchline =
                """"""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                public GeselecteerdeKanaal: number;
                public GeselecteerdeTemplateOrganisatie: number;
                public GeselecteerdeTemplateVersieId: string;
                public GeselecteerdeBestemmeling: string;
                public GeselecteerdeTerAttentieVan: terAttentieVanContactPersoonModel;
                """""""""""""""""""""""""""""""""""""""""""""""""""""""""""";

            return null;
        }

        public IEnumerable<Joke> GetJokes()
        {
            var filename = @"Data\dadJokes.json";
            using StreamReader reader = new StreamReader(filename);
            var json = reader.ReadToEnd();
            IEnumerable<ResponseJoke> source = JsonSerializer.Deserialize<IEnumerable<ResponseJoke>>(json);
            var jokes = source.Select(joke => new Joke()
            {
                Id = joke.id,
                Setup = joke.setup,
                Punchline = joke.punchline,
                Is12Plus = joke.is12Plus,
                Is18Plus = joke.is18Plus,
                Created = joke.created.ParseDate(),
                Language = joke.language,
                Author = joke.author.ConvertToPerson()
            });
            return jokes;
        }
    }
}
