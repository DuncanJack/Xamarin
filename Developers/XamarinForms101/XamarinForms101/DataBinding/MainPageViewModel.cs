using System;
using System.ComponentModel;

namespace XamarinForms101.DataBinding
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if(value != _name)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(DisplayName));
                }
            }
        }

        public string DisplayName => $"Name Entered: {Name}";

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}