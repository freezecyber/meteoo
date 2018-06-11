using datestver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather;

namespace meteoo
{
    static class Program
    {
        public static HttpClient clientd = new HttpClient();
        private static bool open1 = false;
        private static string url1;
        private static string url2;
        private static string json;
        private static IPAddress bvb;
        public static string ftgg;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("Bienvenue sur le programe Pour la Compagnie" + Environment.NewLine + "nous sommes fier de vous presenter" + Environment.NewLine + " linterface avec intelligence artificiel" + Environment.NewLine + "elle peut apprendre evoluer et changer");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("Creer par : YAN BERGERON");
            Console.WriteLine("--------");

            string fth = File.ReadAllText("directory.tx");
            ftgg = fth;
            System.IO.Directory.SetCurrentDirectory(fth);
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(ftgg);
                Environment.CurrentDirectory = ftgg;

                Properties.Settings.Default.Save();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
            // Print to console the results.
            Console.WriteLine("Root directory: {0}", Directory.GetDirectoryRoot(ftgg));
            Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());



            try
            {
                string myHost = System.Net.Dns.GetHostName();
                string myIP = null;

                for (int i = 0; i <= System.Net.Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
                {
                    if (System.Net.Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                    {
                        myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[i].ToString();
                    }
                }
                Console.WriteLine("--------");
                Console.WriteLine("local ip : " + myIP);
                var xg = Environment.SystemPageSize;
                Console.WriteLine("--------");
                Console.WriteLine("memory paging loaded : " + xg);
                string[] sss = Environment.GetLogicalDrives();
                Console.WriteLine("logical drives : ");
                foreach (string bf in sss)
                {
                    Console.Write(bf);
                }
                var stt = Environment.MachineName;
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.WriteLine("machinne name : " + stt);
                int tre = Environment.ProcessorCount;
                Console.WriteLine("--------");
                Console.WriteLine("processor count : " + tre);
                bvb =IPAddress.IPv6Loopback;
                bvb.ToString();
                var sut = Environment.UserDomainName;
                Console.WriteLine("--------");
                Console.WriteLine("network name : " + myHost);
                var scx = Environment.UserName;
                Console.WriteLine("--------");
                Console.WriteLine("user name : " + scx);
                var syr = Environment.Version;
                Console.WriteLine("--------");
                var syre = Environment.OSVersion;
                Console.WriteLine("os ver : " + syre);
                Console.WriteLine("--------");
                Console.WriteLine("ver : " + syr);
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                Console.WriteLine("--------");
                Console.WriteLine("ip adress : " + externalip);

                Console.WriteLine("--------");

                var sfg = Environment.UserInteractive;
                Console.WriteLine("interactif : " + sfg);
            }
            catch { Console.WriteLine("error environement"); }

            Thread dsjdf = new Thread(new ThreadStart(ftg));
            dsjdf.Start();
            do
            {
                Console.WriteLine("Type :  y  : to open Form");
   
                   var cmm = Console.ReadLine();
                if (cmm == "y")
                {
                    Console.WriteLine("opening");
   
                       Thread ddsjdf = new Thread(new ThreadStart(dftg));
                    ddsjdf.Start();
                   

                }
                else
                {
                    Console.WriteLine("return");
   
                       Console.ReadLine();

                }
            } while (true);

        }

        private static void dftg()
        {
            Console.WriteLine("star form");
   
               wheat ksj = new wheat();
            Application.Run(ksj);
        }

        public static void sayt(string hdgf)
        {
            System.Speech.Synthesis.SpeechSynthesizer skdf = new System.Speech.Synthesis.SpeechSynthesizer();
            skdf.SelectVoice("Microsoft Hortense Desktop");
            skdf.SpeakAsync(hdgf);
        }
        public static void ftg()
        { do {
                
                if (!open1)
                {
                    Console.WriteLine("search meteo");
   
                       Thread.Sleep(0);
                    Application.DoEvents();
                    open1 = true;
                    try
                    {
                        url1 = "http://api.openweathermap.org/data/2.5/weather?q=saguenay&appid=dfbd9862a903062c9442bd69db905961&units=metric&lang=fr";
                        json = clientd.GetStringAsync(url1).Result;

                       
                        cWeather wea = JsonConvert.DeserializeObject<cWeather>(json);
                        Console.WriteLine("saguenay");

                        Console.WriteLine(Convert.ToString(wea.main.temp) + " °C");

                        Console.WriteLine(Convert.ToString(wea.main.humidity) + " %");

                        Console.WriteLine(Convert.ToString(wea.main.pressure) + " hpa");

                        Console.WriteLine(Convert.ToString(wea.wind.speed + " m/s"));

                        Console.WriteLine(Convert.ToString(wea.weather.ElementAt(0).description));

                        url2 = "http://openweathermap.org/img/w/" + Convert.ToString(wea.weather.ElementAt(0).icon + ".png");


                        sayt("la temperature pour saguenay est de " + wea.main.temp + " °C" + " et lhumidity " + wea.main.humidity + " %");


                    }
                    catch {
                        Console.WriteLine("error 1"); }

                 open1 = true;
                }
                else
                {
                    Console.WriteLine("searching");
   
                       Thread.Sleep(0);
                    Application.DoEvents();
                    open1 = false;
                    try
                    {
                        Class5 lm = new Class5();
                        lm.GetWeather();
                    }
                    catch {
                        Console.WriteLine("error 2"); }

                 open1 = false;

                }

                Application.DoEvents();

                Thread.Sleep(1200000);
                Console.WriteLine("sleep done");
            } while (true);
        }
    }
}
