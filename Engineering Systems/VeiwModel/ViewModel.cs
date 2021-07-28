using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engineering_Systems.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Database databaseB = new Database();
        Database databaseWH = new Database();
        Database databaseBP = new Database();
        Database dataBaseF = new Database();
        Database dataBaseHM = new Database();
        public List<Data> Boilers { get; set; }
        public List<Data> WaterHeats { get; set; }
        public List<Data> BoilerPipe { get; set; }
        public List<Data> Flors { get; set; }
        public List<Data> HeatMethod { get; set; }
        public ViewModel()
        {
            List<Data> boilers = databaseB.Boilers;
            Boilers = boilers;
            List<Data> waterHeats = databaseB.WaterHeats;
            WaterHeats = waterHeats;
            List<Data> boilerPipe = databaseBP.BoilerPipe;
            BoilerPipe = boilerPipe;
            List<Data> flors = dataBaseF.Flors;
            Flors = flors;
            List<Data> heatMethod = dataBaseHM.HeatMethod;
            HeatMethod = heatMethod;
        }


    }
}
