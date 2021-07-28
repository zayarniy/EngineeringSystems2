using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering_Systems
{
    class Data
    {
        public string Nomenc { get; set; }
        public int Price { get; set; }

        public Data (string Nomenc, int Price)
        {
            this.Nomenc = Nomenc;
            this.Price = Price;
        }
    }
    class Database
    {
        public List<Data> Boilers = new List<Data>();
        public List<Data> WaterHeats = new List<Data>();
        public List<Data> BoilerPipe = new List<Data>();
        public List<Data> Flors = new List<Data>();
        public List<Data> HeatMethod = new List<Data>();
        public Database()
        {
            Boilers.Add(new Data("Нет",  0));
            Boilers.Add(new Data("Газовый", 150));
            Boilers.Add(new Data("Электро", 100));
            Boilers.Add(new Data("Тепловой насос", 250));
            
            WaterHeats.Add(new Data("Нет", 0));
            WaterHeats.Add(new Data("Электрический", 100));
            WaterHeats.Add(new Data("БКН", 150));
            
            BoilerPipe.Add(new Data("Нет",0));
            BoilerPipe.Add(new Data("Пайка медью", 100));
            BoilerPipe.Add(new Data("Прес металл", 150));

            Flors.Add(new Data("1", 100));
            Flors.Add(new Data("2", 200));
            Flors.Add(new Data("3", 300));

            HeatMethod.Add(new Data("Радиаторы", 100));
            HeatMethod.Add(new Data("Теплый пол", 200));


        }
        
    }
}
