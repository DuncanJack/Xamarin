using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            set
            {
                if(dateTime != value)
                {
                    dateTime = value;

                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }

        public ClockViewModel()
        {
            this.dateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }
    }
}
