using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabViewSample
{
    internal class ContactsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string[]? listCollection;

        public string[]? ContactsListCollection
        {
            get { return listCollection; }
            set { listCollection = value; OnPropertyChanged(nameof(ContactsListCollection)); }

        }

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ContactsViewModel()
        {
            ContactsListCollection = new string[]
            {
                "Sandra",
                "Richard",
                "Michael",
                "Alex",
                "Clara",
                "Steve",
                "Mark",
                "Alan",
                "Sandra",
                "Ryan"
            };
        }

    }
}

