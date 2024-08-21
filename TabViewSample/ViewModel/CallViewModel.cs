using System.ComponentModel;

namespace TabViewSample
{
    public class CallViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string[]? listCollection;

        public string[]? CallListCollection
        {
            get { return listCollection; }
            set { listCollection = value; OnPropertyChanged(nameof(CallListCollection)); }

        }

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CallViewModel()
        {
            CallListCollection = new string[]
            {
                "Steve",
                "Mark",
                "Alan",
                "Sandra",
                "Ryan"
            };
        }

    }
}
