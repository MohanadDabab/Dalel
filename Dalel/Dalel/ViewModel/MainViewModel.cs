using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dalel.Model;
using Dalel.Services;
using Xamarin.Forms;

namespace Dalel.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<LocationInfo> _locationList;
        private bool _DoneFetch;
         private bool _isRefreshing = false;

        public List<LocationInfo> LocationList
        { get
            {
                return _locationList;
            }
          set
            {
                _locationList = value;
                OnPropertyCannged();

            }

        }

        public bool DoneFetch {
            get
            {
                return _DoneFetch;
            }
            set
            {
                _DoneFetch = value;
                OnPropertyCannged();

            }

        }

       
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyCannged(nameof(IsRefreshing));
            }
        }

        public MainViewModel()
        {

            InitData();

        }

        private async Task InitData()
        {
            var LocationService = new LocationServices();
            DoneFetch = true;
            LocationList = await LocationService.GetLocation();
            DoneFetch = false;
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await InitData();

                    IsRefreshing = false;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyCannged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
