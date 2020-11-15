using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Helpers
{
   public static class BitStampValidator
    {
        public static string SignInRequest(string ApiKeySecret, string TimeStamp, string clientID)
        {
            var TempPayload = TimeStamp + clientID + ApiKeySecret;

            byte[] payload = Encoding.UTF8.GetBytes(TempPayload);

            using (HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(ApiKeySecret)))
            {
                byte[] hash = hmac.ComputeHash(payload);
                return ConvertToHexString(hash);
            }
        }

        private static string ConvertToHexString(byte[] hash)
        {
            StringBuilder result = new StringBuilder(hash.Length * 2);

            foreach (var c in hash)
            {
                result.Append(c.ToString("x2"));
            }

            return result.ToString();
        }

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }
    }
}
