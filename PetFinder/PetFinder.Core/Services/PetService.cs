using PetFinder.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Core.Services
{
    public class PetService
    {
        private const string ApiKey = "821f3887cf7776014563f57289a2f097";
        private const string SecretKey = "0509cf5a947b418064821015ff88b4ef";

        public static string GetPet()
        {
            string hash;

            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, ApiKey + SecretKey);
            }

            return hash;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
