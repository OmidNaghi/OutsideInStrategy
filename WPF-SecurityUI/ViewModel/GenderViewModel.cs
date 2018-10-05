using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SecurityUI.DataProvider;

namespace WPF_SecurityUI.ViewModel
{
    public class GenderViewModel
    {
        public ObservableCollection<Gender> Genders { get; set; }
        private IDataProvider<Gender> _GenderDataProvider;

        public GenderViewModel(IDataProvider<Gender> GenderDataProvider)
        {
            Genders = new ObservableCollection<Gender>();
            _GenderDataProvider = GenderDataProvider;
        }

        public void Load()
        {
            Genders = new ObservableCollection<Gender>(_GenderDataProvider.ReadAll());
        }
    }
}
