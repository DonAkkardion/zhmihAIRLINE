using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Model.Models;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Text.RegularExpressions;
using WPF.DAL.Impl;
using WPF.DAL.Impl.Mappers;
using WPF.Entity.Entities;
using WPF.DAL.Impl.Repository;
using WPF.BL.Impl.Service;

namespace WPF.ViewModel.VM
{

    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Flight> _FlightList;
        public List<Flight> FlightList
        {
            get { return this._FlightList; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private UnitOfWork _unitOfWork;
        public MainViewModel()
        {
            AirportContext airportContext = new AirportContext();
            _unitOfWork = new UnitOfWork(airportContext);
      
            Airport airport = new Airport();
            Airport = airport;

            FlightService flightService = new FlightService(_unitOfWork);
            GetPassengerService getpass = new GetPassengerService(_unitOfWork);


            Airport.ListOfFlights = flightService.GetFlights();
            Airport.ListOfPassengers = getpass.GetPassenger();
            GetFlightName = Airport.GetFlightNames();

           

            //this._FlightList = new List<Flight>(Airport.ListOfFlights);

        }



        List<string> _GetFlightName;
        public List<string> GetFlightName
        {
            get => _GetFlightName;
            set
            {
                _GetFlightName = value;
                OnPropertyChanged("GetFlightName");
            }
        }

        List<string> _GetListOfPassenger;
        public List<string> GetListOfPassenger
        {
            get => _GetListOfPassenger;
            set
            {
                _GetListOfPassenger = value;
                OnPropertyChanged("GetListOfPassenger");
            }
        }

        string _FlightName;
        public string FlightName
        {
            get => _FlightName;
            set
            {
                _FlightName = value;
            }
        }

        string _FlightTime;
        public string FlightTime
        {
            get => _FlightTime;
            set
            {
                _FlightTime = value;
                OnPropertyChanged("FlightTime");
            }
        }

        string _FlightDelayTime;
        public string FlightDelayTime
        {
            get => _FlightDelayTime;
            set
            {
                _FlightDelayTime = value;
                OnPropertyChanged("FlightDelayTime");
            }
        }

        string _FlightLastBuyTime;
        public string FlightLastBuyTime
        {
            get => _FlightLastBuyTime;
            set
            {
                _FlightLastBuyTime = value;
                OnPropertyChanged("FlightLastBuyTime");
            }
        }

        string _FlightPlane;
        public string FlightPlane
        {
            get => _FlightPlane;
            set
            {
                _FlightPlane = value;
                OnPropertyChanged("FlightPlane");
            }
        }

        Airport _Airport;
        public Airport Airport
        {
            get => _Airport;
            set
            {
                _Airport = value;
            }
        }

        RelayCommand _InfoCommand;
        public ICommand InfoCommand
        {
            get
            {
                if (_InfoCommand == null)
                    _InfoCommand = new RelayCommand(ExecuteInfoCommand, CanExecuteInfoCommand);
                return _InfoCommand;
            }
        }
        private void ExecuteInfoCommand(object parameter)
        {
            var f = this.Airport.GetFlight(FlightName);
            FlightTime = f.Time.ToString();
            FlightDelayTime = f.DelayTime.ToString();
            //FlightPlane = f.Plane.ToString();
            FlightLastBuyTime = f.LastBuyTime.ToString();

            PassengerService passengerService = new PassengerService(_unitOfWork);

            foreach (Flight F in Airport.ListOfFlights)
            {
                F.ListOfPassengers = passengerService.GetPassengerWhereFlightID(F.ID);
            }

            GetListOfPassenger = f.GetPassengerList();
        }
        private bool CanExecuteInfoCommand(object parameter)
        {
            if (FlightName != null)
                return true;
            return false;
        }

        RelayCommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new RelayCommand(ExecuteSaveCommand, CanExecuteSaveCommand);
                return _SaveCommand;
            }
        }
        private void ExecuteSaveCommand(object parameter)
        {
            Airport.ChangeTime(FlightName, TimeSpan.Parse(FlightDelayTime), DateTime.Parse(FlightLastBuyTime, null));
            this._FlightList = new List<Flight>(Airport.ListOfFlights);       
        
            //okoshko
        }
        private bool CanExecuteSaveCommand(object parameter)
        {
            var reg = new Regex("^([2][0-3]|[0-1][0-9]):[0-5][0-9]:[0-5][0-9]$");
            var reg2 = new Regex("^([3][0]|[1-2][0-9]|[0][1-9]).([0][1-9]|[1][0-2]).[2][0][2][0-9]\\s([2][0-3]|[0-1][0-9]|[][0-9]):[0-5][0-9]:[0-5][0-9]$");
            /*if (FlightDelayTime != null && reg.IsMatch(FlightDelayTime) && reg2.IsMatch(FlightLastBuyTime))*/
            if (FlightDelayTime != null && reg.IsMatch(FlightDelayTime) && reg2.IsMatch(FlightLastBuyTime))
                return true;
            return false;
        }

       


    }

}
