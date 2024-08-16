using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabViewSample
{
    public class FavoriteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string[]? listCollection;

        public string[]? FavoriteListCollection
        {
            get { return listCollection; }
            set { listCollection = value; OnPropertyChanged(nameof(FavoriteListCollection)); }

        }

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public FavoriteViewModel()
        {
            FavoriteListCollection = new string[]
            {
                "Sandra",
                "Richard",
                "Michael",
                "Alex",
                "Clara"
            };
        }

    }
}

