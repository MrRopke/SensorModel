using System;
using System.Collections.Generic;
using System.Text;

namespace SensorModels
{
    public class SensorData
    {
        public int Id { get; set; }
        public double Humidity { get; set; }
        public DateTimeOffset Date { get; set; }
        public string FK_MacAddress { get; set; }
    }
}
