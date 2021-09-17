using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Dapper;
using RestSharp;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        RestClient _restClient = new RestClient();
        HistoricalData _historicalData = new HistoricalData();
        string _weatherDataConnString = ConfigurationManager.ConnectionStrings["WeatherData"].ConnectionString;
        string _weatherAPIKey = ConfigurationManager.AppSettings["opeanWeatherAPIKey"];

        public WeatherForm()
        {
            InitializeComponent();
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateCities();
                PopulateHistoricalData();
            }
            catch(Exception ex)
            {
                lblErrors.Text = $"Error: {ex.Message}";
            }
        }

        private void PopulateCities()
        {
            cbCity.SelectedIndexChanged -= new EventHandler(CbCity_SelectedIndexChanged);
            var query = "Select * From City";

            using (IDbConnection connectionString = new SqlConnection(_weatherDataConnString))
            {
                var cities = connectionString.Query<City>(query).OrderBy(c => c.Name).ToList();
                cbCity.DataSource = cities;
                cbCity.DisplayMember = "Name";
                cbCity.SelectedIndex = -1;
            }
            cbCity.SelectedIndexChanged += new EventHandler(CbCity_SelectedIndexChanged);
        }

        private void PopulateHistoricalData()
        {
            var query = "Select Historical.Id as HistoricalId, City.Name as City, Date, Conditions, Temperature, WindSpeed, Humidity, CloudCover " +
                        "From Historical Join City on City.Id = Historical.CityId";

            using (IDbConnection connectionString = new SqlConnection(_weatherDataConnString))
            {
                var historicalData = connectionString.Query<HistoricalData>(query);
                dgvHistoricalData.DataSource = null;
                dgvHistoricalData.DataSource = historicalData;

                dgvHistoricalData.Columns["HistoricalId"].DataPropertyName = "HistoricalId";
                dgvHistoricalData.Columns["City"].DataPropertyName = "City";
                dgvHistoricalData.Columns["Date"].DataPropertyName = "Date";
                dgvHistoricalData.Columns["HistoricalId"].Visible = false;
                dgvHistoricalData.Columns["CityId"].Visible = false;
                dgvHistoricalData.Columns["Conditions"].Visible = false;
                dgvHistoricalData.Columns["Temperature"].Visible = false;
                dgvHistoricalData.Columns["WindSpeed"].Visible = false;
                dgvHistoricalData.Columns["Humidity"].Visible = false;
                dgvHistoricalData.Columns["CloudCover"].Visible = false;
            }
        }

        private HttpStatusCode GetWeather(object selectedCity)
        {
            var resource = string.Format($"/data/2.5/weather?q={((City)selectedCity).Name}&appid={_weatherAPIKey}");
            var request = new RestRequest(resource);
            request.AddParameter("units", "imperial");
            _restClient.BaseUrl = new Uri("https://api.openweathermap.org");
            var result = _restClient.ExecuteAsync<WeatherInfo>(request, Method.GET).GetAwaiter().GetResult();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var resultJson = JsonConvert.DeserializeObject<WeatherInfo>(result.Content);

                _historicalData.City = ((City)selectedCity).Name;
                _historicalData.CityId = ((City)selectedCity).Id;
                _historicalData.Conditions = resultJson.weather[0].description;
                _historicalData.Temperature = (int)resultJson.main.temp;
                _historicalData.WindSpeed = (int)resultJson.wind.speed;
                _historicalData.Humidity = resultJson.main.humidity;
                _historicalData.CloudCover = resultJson.clouds.all;
                _historicalData.Date = DateTime.Now;
            }
            else
            {
                lblErrors.Text = "Error retieving weather data.";
            }

            return result.StatusCode;
        }

        private void DisplayWeather()
        {
            lblCity.Text = _historicalData.City;
            lblDate.Text = _historicalData.Date.ToString();
            lblCurrentConditionsDescrip.Text = _historicalData.Conditions;
            lblTemperature.Text = $"{_historicalData.Temperature} °F";
            lblWindSpeed.Text = $"{_historicalData.WindSpeed} MPH";
            lblHumidity.Text = $"{_historicalData.Humidity} %";
            lblCloudCover.Text = $"{_historicalData.CloudCover} %";
        }

        private void InsertHistoricalData()
        {
            var query = "INSERT INTO Historical (CityId, Conditions, Temperature, WindSpeed, Humidity, CloudCover, Date)" +
                        "Values (@CityId, @Conditions, @Temperature, @WindSpeed, @Humidity, @CloudCover, @Date);";

            using (IDbConnection connectionString = new SqlConnection(_weatherDataConnString))
            {
                connectionString.Execute(query, _historicalData);
            }
        }

        private void DeleteHistoricalData(int historicalId)
        {
            var query = "DELETE FROM Historical WHERE Id = @HistoricalId";

            using (IDbConnection connectionString = new SqlConnection(_weatherDataConnString))
            {
                connectionString.Execute(query, new { HistoricalId = historicalId });
            }
        }

        private void CbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrors.Text = string.Empty;

            if (cbCity.SelectedIndex != -1)
            {
                var status = GetWeather(cbCity.SelectedItem);

                if (status == HttpStatusCode.OK)
                {
                    DisplayWeather();
                    InsertHistoricalData();
                    PopulateHistoricalData();
                }
            }
        }

        private void DgvHistoricalData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrors.Text = string.Empty;

            if (e.RowIndex != -1)
            {
                var row = dgvHistoricalData.Rows[e.RowIndex];
                var historicalId = row.Cells["WindSpeed"].Value;

                _historicalData.City = row.Cells["City"].Value.ToString();
                _historicalData.CityId = (int)row.Cells["WindSpeed"].Value;
                _historicalData.Conditions = row.Cells["Conditions"].Value.ToString();
                _historicalData.Temperature = (int)row.Cells["Temperature"].Value;
                _historicalData.WindSpeed = (int)row.Cells["WindSpeed"].Value;
                _historicalData.Humidity = (int)row.Cells["Humidity"].Value;
                _historicalData.CloudCover = (int)row.Cells["CloudCover"].Value;
                _historicalData.Date = (DateTime)row.Cells["Date"].Value;

                DisplayWeather();
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            var deleteRow = dgvHistoricalData.SelectedRows;
            var row = dgvHistoricalData.Rows[deleteRow[0].Index];
            var historicalId = (int)row.Cells["HistoricalId"].Value;
            DeleteHistoricalData(historicalId);
            PopulateHistoricalData();

            lblCity.Text = string.Empty;
            lblDate.Text = string.Empty;
            lblCurrentConditionsDescrip.Text = string.Empty;
            lblTemperature.Text = string.Empty;
            lblWindSpeed.Text = string.Empty;
            lblHumidity.Text = string.Empty;
            lblCloudCover.Text = string.Empty;
        }
    }
}
