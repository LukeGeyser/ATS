﻿using ATS.Helpers;
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
        public static void Get(string ApiKey, string ApiKeySecret, string clientID)
        {
            var _timestamp = BitStampValidator.GetTimeStamp();
           
            IRestResponse response;

            try
            {
                HttpWebRequest getApiRequest = (HttpWebRequest)HttpWebRequest.Create("https://www.bitstamp.net/api/ticker/");
                getApiRequest.Method = "POST";
                

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                getApiRequest.ContentType = "application/x-www-form-urlencoded;";

                string FormData = $"key={BitStampValidator.SignInRequest(ApiKey, _timestamp, clientID)}&nonce=" + _timestamp ;
                StreamWriter formWrite = new StreamWriter(getApiRequest.GetRequestStream());
                formWrite.Write(FormData);
                formWrite.Flush();
                formWrite.Close();


                StreamReader resultReader = new StreamReader(getApiRequest.GetResponse().GetResponseStream());
                string result = resultReader.ReadToEnd();
                resultReader.Close();


                Debug.WriteLine(result);

            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

            
        }


    }
}
