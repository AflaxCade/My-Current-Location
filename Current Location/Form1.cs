using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Current_Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetLocation_Click(object sender, EventArgs e)
        {
            string ip = await new WebClient().DownloadStringTaskAsync("https://api.ipify.org");
            string url = $"http://ip-api.com/json/{ip}?fields=city,country,lat,lon";
            string json = await new WebClient().DownloadStringTaskAsync(url);
            dynamic result = JsonConvert.DeserializeObject(json);
            string city = result.city;
            string country = result.country;
            double latitude = result.lat;
            double longitude = result.lon;
            //MessageBox.Show($"You are currently in {city}, {country} at Latitude: {latitude}, Longitude: {longitude}.");
            location.Text = $"{city}, {country}";
            lat.Text = $"Latitude: {latitude}";
            lon.Text = $"Longitude: {longitude}";
        }
    }
}