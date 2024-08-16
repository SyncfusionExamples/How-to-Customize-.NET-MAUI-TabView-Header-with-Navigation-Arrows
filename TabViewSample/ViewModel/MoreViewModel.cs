using System.ComponentModel;

namespace TabViewSample
{
    public class MoreViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? text="More Content";
        public string? Text
        {
            get { return text; } 
            set { text = value; OnPropertyChanged("Text"); }
        }
        public MoreViewModel()
        {
            
        }
    }

}
