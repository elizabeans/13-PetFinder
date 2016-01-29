using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PetFinder.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetFinder.Core.Services
{
    public class PetService
    {
        private const string ApiKey = "821f3887cf7776014563f57289a2f097";
        private const string SecretKey = "0509cf5a947b418064821015ff88b4ef";

        public static string GetPetId()
        {
            // retrieves Pet ID # for random pet profile
            using (WebClient wc = new WebClient())
            { 
                string petId = wc.DownloadString($"http://api.petfinder.com/pet.getRandom?key={ApiKey}");
                XDocument doc = XDocument.Parse(petId);
                string stuff = JsonConvert.SerializeXNode(doc);
                var o = JObject.Parse(stuff);
                string Id = o["petfinder"]["petIds"]["id"].ToString();
                return Id;
            }
        }


    }
}
