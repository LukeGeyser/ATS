using System;
using System.Text;
using System.Security.Cryptography;

namespace ATS.Helpers
{
    public class ValrValidator
    {
        public static string SignInRequest(string ApiKeySecret, string TimeStamp, string Verb, string Path, string Body = "")
        {
            var TempPayload = TimeStamp + Verb.ToUpper() + Path + Body;

            byte[] payload = Encoding.UTF8.GetBytes(TempPayload);

            using (HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(ApiKeySecret))
            {
                //byte[] hash = hmac.ComputeHash()
            })
            return null;
        }
    }
}
