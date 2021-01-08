using ATS.Helpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Services
{
    public static class ValrService
    {

        public async static Task<IRestResponse> Get(string ApiKey, string ApiKeySecret, string Verb, string Path, string Body = "")
        {
            var _timeStamp = ValrValidator.GetTimeStamp();
            string rqstSig;
            IRestResponse response;

            try
            {
                rqstSig = ValrValidator.SignInRequest(ApiKeySecret, _timeStamp, Verb, Path, Body);

                var client = new RestClient(string.Format($"https://api.valr.com{Path}"));

                client.Timeout = -1;

                var request = new RestRequest((Method)Enum.Parse(typeof(Method), Verb));
                request.AddHeader("X-VALR-API-KEY", ApiKey);
                request.AddHeader("X-VALR-SIGNATURE", rqstSig);
                request.AddHeader("X-VALR-TIMESTAMP", _timeStamp);

                response = await client.ExecuteAsync(request);
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public async static Task<IRestResponse> PostMarketOrder(string ApiKey, string ApiKeySecret, string Verb, string Path, string Body)
        {
            var _timeStamp = ValrValidator.GetTimeStamp();
            string rqstSig;
            IRestResponse response = null;

            try
            {
                rqstSig = ValrValidator.SignInRequest(ApiKeySecret, _timeStamp, Verb, Path, Body);

                var client = new RestClient(string.Format($"https://api.valr.com{Path}"));

                client.Timeout = -1;

                var request = new RestRequest((Method)Enum.Parse(typeof(Method), Verb));
                request.AddHeader("X-VALR-API-KEY", ApiKey);
                request.AddHeader("X-VALR-SIGNATURE", rqstSig);
                request.AddHeader("X-VALR-TIMESTAMP", _timeStamp);
                request.AddParameter("application/json", Body, ParameterType.RequestBody);

                //response = await client.ExecuteAsync(request);
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public async static Task<IRestResponse> GetOrderStatus(string ApiKey, string ApiKeySecret, string Verb, string Path, string Body = "")
        {
            var _timeStamp = ValrValidator.GetTimeStamp();
            string rqstSig;
            IRestResponse response = null;

            try
            {
                rqstSig = ValrValidator.SignInRequest(ApiKeySecret, _timeStamp, Verb, Path, Body);

                var client = new RestClient(string.Format($"https://api.valr.com{Path}"));

                client.Timeout = -1;

                var request = new RestRequest((Method)Enum.Parse(typeof(Method), Verb));
                request.AddHeader("X-VALR-API-KEY", ApiKey);
                request.AddHeader("X-VALR-SIGNATURE", rqstSig);
                request.AddHeader("X-VALR-TIMESTAMP", _timeStamp);

                //response = await client.ExecuteAsync(request);
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

    }
}
