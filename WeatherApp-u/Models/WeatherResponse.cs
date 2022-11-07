using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Main  
    {  
        public double Temp { get; set; }  
        public double Feelslike { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }
    
    public partial class Weather  
    { 
        public string Description { get; set; }
    }
    public class WeatherResponse  
    { 
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; } 
    }
}