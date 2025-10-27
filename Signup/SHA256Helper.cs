using System;
using System.Text;
using System.Security.Cryptography;

namespace AccountUI
{
    internal class SHA256Helper
    {
        public static string Encode(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2")); // chuyển sang hex
                }

                return sb.ToString();
            }
        }
    }
}
