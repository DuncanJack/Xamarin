using System;
using System.ComponentModel;

namespace ErrorRoseAnalysis
{
    public class MyViewModel : INotifyPropertyChanged
    {
        public MyViewModel()
        {
        }

        string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
