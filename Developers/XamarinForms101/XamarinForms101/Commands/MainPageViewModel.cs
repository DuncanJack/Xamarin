using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms101.Commands
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            DecreaseCommand = new Command(DecreaseCount);
            IncreaseCommand = new Command(IncreaseCount);
            SimpleCommand = new Command(() =>
            {
                Console.WriteLine("SimpleCommand");
            });
        }

        public ICommand DecreaseCommand { get; }
        public ICommand IncreaseCommand { get; }
        public ICommand SimpleCommand { get; }

        int count = 0;

        void DecreaseCount()
        {
            count--;
            OnPropertyChanged(nameof(DisplayCount));
        }

        void IncreaseCount()
        {
            count++;
            OnPropertyChanged(nameof(DisplayCount));
        }

        public string DisplayCount => $"You clicked {count} time(s).";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
