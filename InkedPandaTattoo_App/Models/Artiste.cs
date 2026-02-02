using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InkedPandaTattoo_App.Models
{

    public class Artiste
    {
        public long Id { get; set; }

        public string Profession { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;

        public string? Pseudo { get; set; }
        public string? Bio { get; set; }

        public string? Instagram { get; set; }
        public string? Facebook { get; set; }

        public string? BanniereUrl { get; set; }
        public string? VignetteUrl { get; set; }

        public string? Css { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public long UserId { get; set; }
    }

}
