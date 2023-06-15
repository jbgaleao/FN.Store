using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string senha)
        {

            string salt = "|0AC46FD1730941DBAD6764639149FBC405F99C711BB3413CACA8C53A83E6824F";

            byte[] arrayBytes = Encoding.UTF8.GetBytes(senha + salt);
            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
