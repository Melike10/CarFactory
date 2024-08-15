using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class Car
    {

        //Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
        public string SerialNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public int DoorCount { get; set; }

        public Car(string serialNum, string brand, string model, string color, int doorCount)
        {
            SerialNum = serialNum;
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;
            ProductionDate = DateTime.Now;
            
        }
    }
}
