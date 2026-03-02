using InkedPandaTattoo_App.Models;
using InkedPandaTattoo_App.Service;
using InkedPandaTattoo_App.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

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
            AddCommand = new RelayCommand(async _ => await LoadArtistes());

            _ = LoadArtistes();
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
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


        private async Task AddArtistes()
        { 
        }

    }
}