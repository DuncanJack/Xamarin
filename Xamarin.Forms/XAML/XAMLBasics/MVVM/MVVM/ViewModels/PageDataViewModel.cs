using System;
using System.Collections.Generic;
using System.Windows.Input;
using MVVM.Views;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(PageA), "Page A","Description A"),
                new PageDataViewModel(typeof(PageB), "Page B","Description B"),
                new PageDataViewModel(typeof(PageC), "Page C","Description C")
            };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}
