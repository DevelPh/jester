using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jester.OldSchool.Models
{
    public class Joke
    {
        public int Id { get; init; }
        public string Setup { get; init; }
        public required string Punchline { get; set; }
        public bool Is12Plus { get; set; }
        public bool Is18Plus { get; set; }
        public Person Author { get; set; }
        public DateTime Created { get; set; }
        public string Language { get; set; }
    }
}
