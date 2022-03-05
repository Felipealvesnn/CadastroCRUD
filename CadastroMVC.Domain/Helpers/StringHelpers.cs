using System;
using System.Security.Cryptography;
using System.Text;

namespace CadastroMVC.Domain.Helpers
{
    public static class StringHelpers  // guid generator
    {
        public static string Encrypt(this string senha)
        {

            var salt = " | 3C24361795C248D68E6B0454E318EE348AD20392BDE744C794DF6D8CB09D4D3D"; // gerado em uma guid generator
            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);
            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {

                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
