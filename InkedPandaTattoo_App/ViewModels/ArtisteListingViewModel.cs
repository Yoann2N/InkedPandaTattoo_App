using System;
using System.Collections.Generic;
using System.Text;
using InkedPandaTattoo_App.Models;
using System.Windows;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;
using InkedPandaTattoo_App.Service;
using InkedPandaTattoo_App.Models;
using System.Windows.Input;
using mvvmDemo.Commands;

namespace InkedPandaTattoo_App.ViewModels
{
    internal class ArtisteListingViewModel : INotifyPropertyChanged
    {
        private readonly ArtistesService _artistesService = new ArtistesService();

        public ObservableCollection<Artiste> Artistes { get; set; } = new ObservableCollection<Artiste>();

        public Artiste? SelectedArtiste { get; set; }
        public ICommand LoadCommand { get; }

        public ICommand AddCommand { get; }
        public ArtisteListingViewModel()
        {
            LoadCommand = new RelayCommand(async _ => await LoadArtistes());

            _ = LoadArtistes();
        }



        public event PropertyChangedEventHandler? PropertyChanged;
       

    private async Task LoadArtistes()
        {
            try
            {
                var artistes = await _artistesService.GetArtistes();
                Artistes.Clear();
                foreach (var artiste in artistes)
                {
                    Artistes.Add(artiste);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading artistes: {ex.Message}");
            }
        }
    }
}