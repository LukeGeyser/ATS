using ATS.Helpers;
using RestSharp;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ATS.Services
{
   public static class BitStampService
    {
        public async static Task<string> Get(string ApiKey, string clientID)
        {
            var _timestamp = BitStampValidator.GetTimeStamp();
           
            IRestResponse response;
            string currency_pair = "btceur";
            try
            {
                HttpWebRequest getApiRequest = (HttpWebRequest)HttpWebRequest.Create("https://www.bitstamp.net/api/v2/order_book/" + currency_pair + "/");
                getApiRequest.Method = "POST";
                

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                getApiRequest.ContentType = "application/x-www-form-urlencoded;";

                string FormData = $"key={BitStampValidator.SignInRequest(ApiKey, _timestamp, clientID)}&nonce=" + _timestamp ;
                StreamWriter formWrite = new StreamWriter(getApiRequest.GetRequestStream());
                await formWrite.WriteAsync(FormData);
                formWrite.Flush();
                formWrite.Close();


                StreamReader resultReader = new StreamReader(getApiRequest.GetResponse().GetResponseStream());
                string result = resultReader.ReadToEnd();
                resultReader.Close();


                Debug.WriteLine(result);


                return result;
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

            
        }

        public async static Task<IRestResponse> PostMarketOrder(string apiKeySecret, string ApiKey, string amount)
        {
            var _timestamp = BitStampValidator.GetTimeStamp();

            var nonce = Guid.NewGuid().ToString();

            var signature = BitStampValidator.CreateSignatureV2(apiKeySecret, ApiKey, "POST", "www.bitstamp.net", "/api/v2/buy/market/btceur/", "", "application/x-www-form-urlencoded", nonce, _timestamp, "v2", $"amount={amount}");

            IRestResponse response;
            try
            {
                var client = new RestClient("https://www.bitstamp.net/api/v2/buy/market/btceur/");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("X-Auth", $"BITSTAMP {ApiKey}");
                request.AddHeader("X-Auth-Signature", signature);
                request.AddHeader("X-Auth-Nonce", nonce);
                request.AddHeader("X-Auth-Timestamp", _timestamp);
                request.AddHeader("X-Auth-Version", "v2");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("amount", amount);
                return response = await client.ExecuteAsync(request);
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        public async static Task<IRestResponse> GetOrderStatus(string apiKeySecret, string ApiKey, string orderId)
        {
            var _timestamp = BitStampValidator.GetTimeStamp();

            var nonce = Guid.NewGuid().ToString();

            var signature = BitStampValidator.CreateSignatureV2(apiKeySecret, ApiKey, "POST", "www.bitstamp.net", "/api/v2/order_status/", "", "application/x-www-form-urlencoded", nonce, _timestamp, "v2", $"id={orderId}");

            IRestResponse response;
            try
            {
                var client = new RestClient("https://www.bitstamp.net/api/v2/order_status/");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("X-Auth", $"BITSTAMP {ApiKey}");
                request.AddHeader("X-Auth-Signature", signature);
                request.AddHeader("X-Auth-Nonce", nonce);
                request.AddHeader("X-Auth-Timestamp", _timestamp);
                request.AddHeader("X-Auth-Version", "v2");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("id", orderId);
                return response = await client.ExecuteAsync(request);
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}
