using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {

        public static void Conversation()
        {


            HttpClient client = new HttpClient();                                    //the startpoint - the object that allows to make the request

            for (int i = 0; i < 5; i++)
            {            

            #region Ron

            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";    //the endpoint  

            string ronResponse = client.GetStringAsync(ronURL).Result;               //this sends a request and receives back a response as a string

            JArray ronArray = JArray.Parse(ronResponse);                             //parse it into a JArray otherwise unnecessary characters print out

            Console.WriteLine($"Ron: {ronArray[0]}");                                //print the info, need to use indexing to view values cleanly

            #endregion

            #region Kanye

            string kanyeURL = "https://api.kanye.rest/";

            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            JObject kanyeObject = JObject.Parse(kanyeResponse);

            Console.WriteLine($"Kanye: {kanyeObject["quote"]}");
                Console.WriteLine();
                Console.WriteLine();

                #endregion
            }


        }



    }
}
