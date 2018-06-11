using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using System.Net.Http;
using Newtonsoft.Json;

namespace Weather
{
    public partial class wheat : Form
    {
        // ********************************************************************************
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <created>yb,7/26/2017</created>
        /// <changed>yb,7/26/2017</changed>
        // ********************************************************************************
        HttpClient client = new HttpClient();
        string url1;
        string url2;
        string json;

        public wheat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCity.Text == "")
            {
                MessageBox.Show("choisis une ville");
                return;
            }
            try
            {
                url1 = "http://api.openweathermap.org/data/2.5/weather?q="+tbCity.Text +"+&appid=dfbd9862a903062c9442bd69db905961&units=metric&lang=fr";
                json = client.GetStringAsync(url1).Result;


                cWeather wea = JsonConvert.DeserializeObject<cWeather>(json);
                lblName.Text = "saguenay";
                lblName.Visible = true;
                lblTemp.Text = Convert.ToString(wea.main.temp) + " °C";
                lblTemp.Visible = true;
                lblHumidity.Text = Convert.ToString(wea.main.humidity) + " %";
                lblHumidity.Visible = true;
                lblPresure.Text = Convert.ToString(wea.main.pressure) + " hpa";
                lblPresure.Visible = true;
                lblWindSpeed.Text = Convert.ToString(wea.wind.speed + " m/s");
                lblWindSpeed.Visible = true;
                lblDes.Text = Convert.ToString(wea.weather.ElementAt(0).description);
                lblDes.Visible = true;
                url2 = "http://openweathermap.org/img/w/" + Convert.ToString(wea.weather.ElementAt(0).icon + ".png");
                pbWeather.Load(url2);
                pbWeather.Visible = true;


                DateTime time = DateTime.Now;
                lblDt.Text = Convert.ToString(time);
                lblDt.Visible = true;
            }
            catch { }
        }
        private void wheat_Load(object sender, EventArgs e)
        {
            this.Text = "projectyj";
        }
    }
}
