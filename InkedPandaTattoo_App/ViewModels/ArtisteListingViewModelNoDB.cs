using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using InkedPandaTattoo_App.Models;

namespace InkedPandaTattoo_App.ViewModels
{
    internal class ArtisteListingViewModelNoDB
    {
        public ObservableCollection<Models.Artiste> Artistes { get; set; } = new ObservableCollection<Models.Artiste>();
        public ArtisteListingViewModelNoDB() {

                       
            Artistes.Add(new Artiste("toto"));

                       
            Artistes.Add(new Artiste("tata"));

           
            Artistes.Add(new Artiste("titi"));

            Artistes.Add(new Artiste("toto"));


            Artistes.Add(new Artiste("tata"));


            Artistes.Add(new Artiste("titi"));

            Artistes.Add(new Artiste("toto"));


            Artistes.Add(new Artiste("tata"));


            Artistes.Add(new Artiste("titi"));

        }
    }
}
