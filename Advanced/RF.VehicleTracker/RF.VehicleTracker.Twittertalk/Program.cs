using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RF.VehicleTracker.Twittertalk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Pick an operation: ");
                Console.WriteLine("Get my timeline!(T): ");
                Console.WriteLine("Update my status!(U): ");
                Console.WriteLine("Quit(X): ");
                Console.WriteLine();

                //Get the user's operation.
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "u":
                        Update();
                        break;
                    case "t":
                        GetTimeLine();
                        break;
                    case "x":
                        return;
                    default:
                        break;
                }

                Console.WriteLine("Hit <Enter> to continue.");
                Console.ReadLine();
            }
        }

        static void Update()
        {
            // oauth application keys
            var oauth_token = "930140505450647552-6RPYhftmCVE81IrVow08VMl89NxK2pg";
            var oauth_token_secret = "Xvon27fVHFnuIAmzXmV2LaIGNmDcbwaK9jdgoPxEPeYjy";
            var oauth_consumer_key = "p5PJEojUvNCD1Qq3Cu7HMRv0J";
            var oauth_consumer_secret = "b7wFf95FVVpW6dU1qnQCTkb8HjZgqSqP4RUi8WffmjKwMTrWeV";


            // oauth implementation details
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";

            // unique request details
            var oauth_nonce = Convert.ToBase64String(new ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()));


            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();

            // message api details
            var status = "Good Morning from #advprog!!";
            var resource_url = "https://api.twitter.com/1.1/statuses/update.json";

            // create oauth signature
            var baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                            "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&status={6}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_nonce,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_token,
                                        oauth_version,
                                        Uri.EscapeDataString(status)
                                        );

            baseString = string.Concat("POST&", Uri.EscapeDataString(resource_url), "&", Uri.EscapeDataString(baseString));

            var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret),
                                    "&", Uri.EscapeDataString(oauth_token_secret));

            string oauth_signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
            {
                oauth_signature = Convert.ToBase64String(
                    hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }

            // create the request header
            var headerFormat = "OAuth oauth_consumer_key=\"{0}\", oauth_nonce=\"{1}\", oauth_signature=\"{2}\", " +
                               "oauth_signature_method=\"{3}\", oauth_timestamp=\"{4}\", oauth_token=\"{5}\", " +
                               "oauth_version=\"{6}\"";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_version)
                                    );

            // make the request
            var postBody = "status=" + Uri.EscapeDataString(status);

            ServicePointManager.Expect100Continue = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";


            using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
                stream.Write(content, 0, content.Length);
            }

            try
            {
                WebResponse response = request.GetResponse();
                StreamReader oSR = new StreamReader(response.GetResponseStream());
                var responseResult = oSR.ReadToEnd().ToString();
            }
            catch (Exception ex)
            {
                //Common error: If you sent the exact same tweet from the program you will get an error.

                Console.WriteLine("Twitter Post Error: " + ex.Message.ToString() + ", authHeader: " + authHeader);

            }
            Console.ReadLine();
        }

        static void GetTimeLine()
        {
            // oauth application keys
            var oauth_token = "930140505450647552-6RPYhftmCVE81IrVow08VMl89NxK2pg";
            var oauth_token_secret = "Xvon27fVHFnuIAmzXmV2LaIGNmDcbwaK9jdgoPxEPeYjy";
            var oauth_consumer_key = "p5PJEojUvNCD1Qq3Cu7HMRv0J";
            var oauth_consumer_secret = "b7wFf95FVVpW6dU1qnQCTkb8HjZgqSqP4RUi8WffmjKwMTrWeV";



            // oauth implementation details
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";

            // unique request details
            var oauth_nonce = Convert.ToBase64String(new ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()));


            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();

            // message api details
            var resource_url = "https://api.twitter.com/1.1/statuses/user_timeline.json";
            resource_url = "https://api.twitter.com/1.1/statuses/retweets_of_me.json";

            // create oauth signature
            var baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                            "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_nonce,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_token,
                                        oauth_version);

            baseString = string.Concat("GET&", Uri.EscapeDataString(resource_url), "&", Uri.EscapeDataString(baseString));

            var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret),
                                    "&", Uri.EscapeDataString(oauth_token_secret));

            string oauth_signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
            {
                oauth_signature = Convert.ToBase64String(
                    hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }

            // create the request header
            var headerFormat = "OAuth oauth_consumer_key=\"{0}\", oauth_nonce=\"{1}\", oauth_signature=\"{2}\", " +
                               "oauth_signature_method=\"{3}\", oauth_timestamp=\"{4}\", oauth_token=\"{5}\", " +
                               "oauth_version=\"{6}\"";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_version)
                                    );

            // make the request
            var postBody = "screen_name=footeprint&count=5";  // user_timeline
            postBody = "count=1";                             // retweets_of_me

            ServicePointManager.Expect100Continue = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";


            //using (Stream stream = request.GetRequestStream())
            //{
            //    byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
            //    stream.Write(content, 0, content.Length);
            //}

            try
            {
                //WebResponse response = request.GetResponse();
                //StreamReader oSR = new StreamReader(response.GetResponseStream());
                //var responseResult = oSR.ReadToEnd().ToString();

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {

                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    //Response jsonResponse = objResponse as Response;
                    //return jsonResponse;

                    StreamReader oSR = new StreamReader(response.GetResponseStream());

                    string content = oSR.ReadToEnd().ToString();
                    dynamic items = (JArray)JsonConvert.DeserializeObject(content);


                    foreach (var data in items)
                    {
                        Console.WriteLine(data.created_at + ")" +  data.text);
                    }
                    //var responseResult = oSR.ReadToEnd().ToString();
                    //Console.WriteLine(responseResult);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Twitter Post Error: " + ex.Message.ToString() + ", authHeader: " + authHeader);

            }
            Console.ReadLine();
        }
    }
}
