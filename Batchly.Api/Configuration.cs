/*
 * BatchlyApi.PCL
 *
 * This file was automatically generated for Batchly.Api by APIMATIC BETA v2.0 on 03/02/2016
 */
using System;
using System.Configuration;

namespace Batchly.Api
{
    public partial class Configuration
    {
        static readonly String BASE_URI_CONFIG_KEY_NAME = "BatchlyBaseUri";
        static readonly String API_KEY_CONFIG_KEY_NAME = "BatchlyApiKey";
        static readonly String API_SECRET_CONFIG_KEY_NAME = "BatchlyApiSecret";

        public static void LoadFromConfig(){
            var baseUri = ConfigurationManager.AppSettings[BASE_URI_CONFIG_KEY_NAME];
            if (!String.IsNullOrWhiteSpace(baseUri))
            {
                BaseUri = baseUri;
            }

            var apiKey = ConfigurationManager.AppSettings[API_KEY_CONFIG_KEY_NAME];
            if (!String.IsNullOrWhiteSpace(apiKey))
            {
                ApiKey = apiKey;
            }

            var apiSecret = ConfigurationManager.AppSettings[API_SECRET_CONFIG_KEY_NAME];
            if (!String.IsNullOrWhiteSpace(apiSecret))
            {
                ApiSecret = apiSecret;
            }
        }

        //The base Uri for API calls
        public static string BaseUri = String.Empty;
        public static string ApiKey = String.Empty;
        public static string ApiSecret = String.Empty;

    }
}