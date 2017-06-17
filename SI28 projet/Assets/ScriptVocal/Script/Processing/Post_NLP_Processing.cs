
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Web;


namespace UnityHttpReq
{


    static class Post_NLP_Processing
    {
        public static O_NLP.RootObject ParseData(string text)
        {

            // HTML-decode the string, in case it has been HTML encoded
            //string jsonText = HttpUtility.HtmlDecode(text);
            string jsonText = text;
            //Since object is reserved, put a _ in front
            //jsonText = jsonText.Replace("\"object\" : {", "\"_object\" : {");


            //Deserialize into our class
            var rootObject = JsonConvert.DeserializeObject<O_NLP.RootObject>(jsonText);

            return rootObject;
        }
    }
}
