using System;
using System.Text;
using System.Security.Cryptography;

namespace ATS.Helpers
{
    public static class ValrValidator
    {
        public static string SignInRequest(string ApiKeySecret, string TimeStamp, string Verb, string Path, string Body = "")
        {
            var TempPayload = TimeStamp + Verb.ToUpper() + Path + Body;

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

        /* Time-stamp in milliseconds. 
         * The same time-stamp should be used to generate request signature
         * as well as sent along in the X-VALR-TIMESTAMP header of the request
         */

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }
    }
}
