using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace InkedPandaTattoo_App.Models
{

    public class Artiste
    {
        [JsonPropertyName("id")]
        public long Id { get; }

        [JsonPropertyName("profession")]
        public string Profession { get; set; } = string.Empty;

        [JsonPropertyName("style")]
        public string Style { get; set; } = string.Empty;

        [JsonPropertyName("pseudo")]
        public string? Pseudo { get; set; }

        [JsonPropertyName("bio")]
        public string? Bio { get; set; }

        [JsonPropertyName("instagram")]
        public string? Instagram { get; set; }

        [JsonPropertyName("facebook")]
        public string? Facebook { get; set; }

        [JsonPropertyName("banniere_url")]
        public string? BanniereUrl { get; set; }

        [JsonPropertyName("vignette_url")]
        public string? VignetteUrl { get; set; }

        [JsonPropertyName("css")]
        public string? Css { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        public Artiste() { }
        public Artiste(string pseudo)
        {
            Pseudo = pseudo;
        }
    }

}
