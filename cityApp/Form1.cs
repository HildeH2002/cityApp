using cityApp.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace cityApp
{
    public partial class Form1 : Form
    {
        private SavedCityRepository _savedCityRepository;
        private SortedSet<SavedCity> _savedCities;

         
        public class Data
        {
            public int id { get; set; }
            public string wikiDataId { get; set; }
            public string type { get; set; }
            public string city { get; set; }
            public string name { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string region { get; set; }
            public string regionCode { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public int population { get; set; }

        }

        public class Root
        {
            public List<Data> data { get; set; }

        }

        public Form1()
        {
            InitializeComponent();
            _savedCityRepository = new SavedCityRepository();
            _savedCities = new SortedSet<SavedCity>(_savedCityRepository.GetSavedCities());
        }

        private async void btnCityResult_Click(object sender, EventArgs e)
        {
            txtCityResult.Clear();

            string minPopulation = txtMinPopulation.Text;
            string namePrefix = txtNamePrefix.Text;

            string apiString = string.Format("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?limit=10&minPopulation={0}&namePrefix={1}", minPopulation, namePrefix);
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(apiString),
                Headers =
                {
                    { "x-rapidapi-key", "29c2761eeemshafc9d5510c8cf46p1d0242jsna294253be3eb" },
                    { "x-rapidapi-host", "wft-geo-db.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                // var deserializedCities1 = JsonConvert.DeserializeObject<Root>(body);
                // var deserializedCities = JsonConvert.DeserializeObject<Data>(body);

                // citystring = deserializedCities.city;
                

                txtCityResult.Text = (body);

            }
        }


        private void btnSaveCity_Click(object sender, EventArgs e)
        {

            SavedCity savedCity = new SavedCity { City = txtVisitCity.Text, Info = txtExtraInfo.Text };
            _savedCities.Add(savedCity);
            _savedCityRepository.InsertSavedCity(savedCity);

            txtVisitCity.Clear();
            txtExtraInfo.Clear();
        }

        public string citystring;

        private void btnShowSavedCities_Click(object sender, System.EventArgs e)
        {
            txtCityResult.Clear();
            citystring = "";
            foreach (var savedCity in _savedCities)
            {
                citystring += savedCity.City + " - " + savedCity.Info + "\n";
            }
            txtCityResult.Text = (citystring);
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            _savedCities.RemoveWhere(x => x.City == txtCityToRemove.Text);
            _savedCityRepository.DeleteSavedCity(txtCityToRemove.Text);
            txtCityToRemove.Clear();

            txtCityResult.Clear();
            citystring = "";
            foreach (var savedCity in _savedCities)
            {
                citystring += savedCity.City + " - " + savedCity.Info + "\n";
            }
            txtCityResult.Text = (citystring);
        }
    }

}
