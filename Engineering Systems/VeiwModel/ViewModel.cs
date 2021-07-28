using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engineering_Systems.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int _result=0;

        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
               if (_result!=value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
                }
            }
        }
        
        Data _selectedBoiler;
        public Data SelectedBoiler
        {
            get
            {
                return _selectedBoiler;
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("Boiler set");
                if (_selectedBoiler!=value)
                {
                    _selectedBoiler = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedBoiler"));
                    GetResult();
                }
            }
        }

       Data _selectedFloor;
        public Data SelectedFloor
        {
            get
            {
                return _selectedFloor;
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("Floor set");
                if (_selectedFloor != value)
                {
                    _selectedFloor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedFloor"));
                    GetResult();
                }
            }
        }

        void GetResult()
        {
            Result = _selectedBoiler.Price*_selectedFloor.Price;
        }

        Database database = new Database();

        public List<Data> Boilers { get; set; }
        public List<Data> WaterHeats { get; set; }
        public List<Data> BoilerPipe { get; set; }
        public List<Data> Flors { get; set; }
        public List<Data> HeatMethod { get; set; }
        public ViewModel()
        {
            List<Data> boilers = database.Boilers;
            Boilers = boilers;
            List<Data> waterHeats = database.WaterHeats;
            WaterHeats = waterHeats;
            List<Data> boilerPipe = database.BoilerPipe;
            BoilerPipe = boilerPipe;
            List<Data> flors = database.Flors;
            Flors = flors;
            List<Data> heatMethod = database.HeatMethod;
            HeatMethod = heatMethod;
            _selectedBoiler = boilers[0];
            _selectedFloor = flors[0];
        }


    }
}
