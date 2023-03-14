using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jester.OldSchool.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        [MaybeNull]
        public string Name { get; set; }
        public string LinkedInUrl { get; set; }
        public string Email { get; set; }

        public Person() => EnsureIdentifier();

        private void EnsureIdentifier()
        {
            Id = Guid.NewGuid();
        }
    }
}
