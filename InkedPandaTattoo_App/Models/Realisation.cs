using System;
using System.Collections.Generic;
using System.Text;

namespace InkedPandaTattoo_App.Models
{
    internal class Realisation
    {
        public int Id { get; set; }

        public string Titre { get; set; }
        public string? Description { get; set; }
        

        public string? ImageUrl { get; set; }

        public Realisation(int id, string titre, string description, string imageUrl)
        {
            Id = id;
            Titre = titre;
            Description = description;
            ImageUrl = imageUrl;
        }

        public Realisation() 
        {
           Titre = string.Empty;
           

        }
    }
}
