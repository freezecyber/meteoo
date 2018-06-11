using System;
/// <summary></summary>
using System.Linq;
using System.Xml.Linq;

namespace datestver
{
    internal class Class5
    {
        private System.Speech.Synthesis.SpeechSynthesizer say = new System.Speech.Synthesis.SpeechSynthesizer();
        
        public void GetWeather()
        {
           
            say.SelectVoice("Microsoft Hortense Desktop");
            var path = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22saguenay%22)%20and%20u%3D%22c%22&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            var doc = XDocument.Load(path);
            XNamespace ns = "http://xml.weather.yahoo.com/ns/rss/1.0";
            var results = (from i in doc.Descendants(ns + "condition") select i);

            foreach (var thisResult in results)
            {
                Console.WriteLine("la temperature {0} pour dehors et il fait {1}", thisResult.Attribute("temp").Value, thisResult.Attribute("text").Value);
                  say.SpeakAsync(string.Format("la temperature {0} pour dehors et il fait {1}", thisResult.Attribute("temp").Value, thisResult.Attribute("text").Value));
            }
        }
    }
}
