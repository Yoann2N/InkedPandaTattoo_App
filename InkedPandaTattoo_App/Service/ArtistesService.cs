using InkedPandaTattoo_App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Controls;


namespace InkedPandaTattoo_App.Service
{
    internal class ArtistesService
    {
        private readonly HttpClient _httpClient;

        public ArtistesService()
        {
            //_httpClient = new HttpClient{ BaseAddress = new Uri("http://127.0.0.1:8000/api/artistes/")};

            _httpClient = new HttpClient();
            //_httpClient.BaseAddress = new Uri("http://127.0.0.1:8000/api/artistes/");
        }

        
        public async Task<List<Artiste>> GetArtistes()
        {
            var response = await _httpClient.GetAsync("http://127.0.0.1:8000/api/artistes/");
            response.EnsureSuccessStatusCode();

            var artistes = await response.Content.ReadFromJsonAsync<List<Artiste>>();
            return artistes ?? new List<Artiste>();
        }

        public async Task UpdateArtiste(Artiste artiste)
        {
            var json = JsonSerializer.Serialize(artiste);
            var bytes = Encoding.UTF8.GetBytes(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentLength = bytes.Length;

            var response = await _httpClient.PutAsync($"users/{artiste.Id}", content);

            if (response.StatusCode == System.Net.HttpStatusCode.UnprocessableEntity)
            {
                var body = await response.Content.ReadAsStringAsync();
                var error = JsonSerializer.Deserialize<ValidationError>(body);
                throw new Exception(error?.GetDetails() ?? "Erreur de validation");
            }

            response.EnsureSuccessStatusCode();
        }
    }
}
