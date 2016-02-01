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
    }

    /*
    public class Media
    {
        public Photos photos { get; set; }
    }
    
    public class Photos
    {
        public Photo photo { get; set; }
    }

    public class Photo
    {
        public int photoiD = 3;
        public string text { get; set; }
    }
    */
}
