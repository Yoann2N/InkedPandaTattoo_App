using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using InkedPandaTattoo_App.Models;

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
            return artistes; 
        }
    }
}
