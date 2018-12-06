using System;
using System.Collections.Generic;
using System.Text;

namespace SensorModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}
