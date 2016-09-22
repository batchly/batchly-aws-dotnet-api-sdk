using Batchly.PCL.Http.Request;
/*
 * BatchlyApi.PCL
 *
 * This file was automatically generated for Batchly.Api by APIMATIC BETA v2.0 on 03/02/2016
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
namespace Batchly.PCL
{
    internal partial class AuthUtility
    {

        const String HEADER_AUTHORIZATION = "Authorization";
        const String HMAC_TEMPLATE = "Hmac {0}";
        const String HEADER_NONCE = "Nonce";
        const String HEADER_TIMESTAMP = "Timestamp";
        const String HEADER_API_KEY = "Api-Key";
        

        /// <summary>
        /// Appends the necessary Custom Authentication credentials for making this authorized call
        /// </summary>
        /// <param name="request">The out going request to access the resource</param>        
        internal static void AppendCustomAuthParams(HttpRequest request)
        {
            var hmacKeyBase = UrlEncode(Configuration.ApiSecret);

            var uri = new Uri(request.QueryUrl);

            var parameters = new Dictionary<String, String>();
            parameters.Add(HEADER_NONCE, Guid.NewGuid().ToString());
            parameters.Add(HEADER_TIMESTAMP, GetUnixTimeString());
            parameters.Add(HEADER_API_KEY, Configuration.ApiKey );

            var queryParams = ParseQueryString(uri.GetComponents(UriComponents.Query | UriComponents.KeepDelimiter, UriFormat.UriEscaped));
            var stringParameter = FormatQueryString(parameters.Concat(queryParams));

            var signatureBase = request.HttpMethod.ToString().ToUpperInvariant() +
                "&" + UrlEncode(uri.GetComponents(UriComponents.SchemeAndServer | UriComponents.Path, UriFormat.Unescaped)) +
                "&" + UrlEncode(stringParameter);

            var hash = ComputeHash(Encoding.UTF8.GetBytes(hmacKeyBase), Encoding.UTF8.GetBytes(signatureBase));
            var auth = String.Format(HMAC_TEMPLATE, UrlEncode(Convert.ToBase64String(hash)));
            parameters.Add(HEADER_AUTHORIZATION, auth);
            request.Headers = request.Headers.Concat(parameters).ToDictionary(x => x.Key, x => x.Value); 
        }

        private static String UrlEncode(String stringToEscape)
        {
            return Uri.EscapeDataString(stringToEscape)
                .Replace("!", "%21")
                .Replace("*", "%2A")
                .Replace("'", "%27")
                .Replace("(", "%28")
                .Replace(")", "%29");
        }

        private static Byte[] ComputeHash(byte[] key, byte[] buffer)
        {
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(buffer);
            }
        }

        private static String FormatQueryString(IEnumerable<KeyValuePair<String, String>> parameters)
        {
            var stringParameters = parameters
                .Where(x => x.Key.ToUpperInvariant() != "REALM")
                .Select(p => new { Key = UrlEncode(p.Key), Value = UrlEncode((String)p.Value) })
                .OrderBy(p => p.Key, StringComparer.Ordinal)
                .ThenBy(p => p.Value, StringComparer.Ordinal)
                .Select(p => p.Key + "=" + p.Value);

            return string.Join("&", stringParameters);
        }

        private static IEnumerable<KeyValuePair<String, String>> ParseQueryString(String query)
        {
            //query is optional for an API call, so it may be null
            if (string.IsNullOrEmpty(query))
                return Enumerable.Empty<KeyValuePair<String, String>>();

            var queryParams = query.TrimStart('?').Split('&')
               .Where(x => x != "")
               .Select(x =>
               {
                   var xs = x.Split('=');
                   return new KeyValuePair<String, String>(UrlDecode(xs[0]), UrlDecode(xs[1]));
               });

            return queryParams;
        }

        private static String UrlDecode(string stringToUnescape)
        {
            stringToUnescape = stringToUnescape.Replace("+", " ");
            return Uri.UnescapeDataString(stringToUnescape)
                .Replace("%21", "!")
                .Replace("%2A", "*")
                .Replace("%27", "'")
                .Replace("%28", "(")
                .Replace("%29", ")");
        }

        private static String GetUnixTimeString()
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return ((long)(DateTime.UtcNow - unixEpoch).TotalSeconds).ToString();
        }
    }
}
