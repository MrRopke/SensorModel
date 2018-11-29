using System;

namespace SensorModels
{
    public class Sensor
    {
        public string MacAddress { get; set; }
        public string Name { get; set; }
        public double LimitUp { get; set; }
        public double LimitLow { get; set; }
        public int FK_UserId { get; set; }
        public SensorData Data { get; set; }
    }
}
