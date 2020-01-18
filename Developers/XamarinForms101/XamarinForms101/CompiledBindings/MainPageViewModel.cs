using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace XamarinForms101.CompiledBindings
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
        }

        public Person Person => People.First();

        public List<Person> People => new List<Person>
        {
            new Person{ Name="A", PersonId=1},
            new Person{ Name="B", PersonId=2}
        };

        private string _name = string.Empty;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == _name) return;
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
