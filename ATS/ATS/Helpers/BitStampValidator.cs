using RestSharp.Extensions;
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

        public static string CreateSignatureV2(string apiKeySecret, string apiKey, string httpVerb, string urlHost, string urlPath, string urlQuery, string urlContentType, string nonce, string timeStamp, string authVersion, string reqBody)
        {
            var TempPayload = string.Format($"BITSTAMP {apiKey}{httpVerb}{urlHost}{urlPath}{urlQuery}{urlContentType}{nonce}{timeStamp}{authVersion}{(string.IsNullOrEmpty(reqBody) == true ? null : reqBody)}");
            byte[] payload = Encoding.UTF8.GetBytes(TempPayload);
            

            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(apiKeySecret)))
            {
                byte[] hash = hmac.ComputeHash(payload);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
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

        public static string GenerateNonce()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bit_count = (32 * 6);
                var byte_count = ((bit_count + 7) / 8); // rounded up
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
            
        }

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }
    }
}
