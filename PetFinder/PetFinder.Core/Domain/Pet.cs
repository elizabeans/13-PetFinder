using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Core.Domain
{
    public class Pet
    {
        public string name { get; set; }
        public string age { get; set; }
        public string image { get; set; }
        public Contact contact { get; set; }
    }

    public class Contact
    {
        public string email { get; set; }
    }
}
