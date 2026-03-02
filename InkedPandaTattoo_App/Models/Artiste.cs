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

        [JsonPropertyName("Profession")]
        public string Profession { get; set; } = string.Empty;

        [JsonPropertyName("Style")]
        public string Style { get; set; } = string.Empty;

        [JsonPropertyName("Pseudo")]
        public string? Pseudo { get; set; }

        [JsonPropertyName("Bio")]
        public string? Bio { get; set; }

        [JsonPropertyName("Instagram")]
        public string? Instagram { get; set; }

        [JsonPropertyName("Facebook")]
        public string? Facebook { get; set; }

        [JsonPropertyName("BanniereUrl")]
        public string? BanniereUrl { get; set; }

        [JsonPropertyName("VignetteUrl")]
        public string? VignetteUrl { get; set; }

        [JsonPropertyName("Css")]
        public string? Css { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public long UserId { get; set; }

        public Artiste() { }
        public Artiste(string pseudo)
        {
            Pseudo = pseudo;
        }
    }

}
