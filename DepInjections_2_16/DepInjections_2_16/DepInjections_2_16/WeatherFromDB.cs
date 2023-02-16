using DependInjection;
using DependInjectionl;

namespace DepInjections_2_16; 

public class WeatherFromDB : IWeatherData {
    public List<HiPerMonth> GetWeatherData() {
        DBConnect DB = new DBConnect();
        return DB.SelectWeatherRecords();
    }
}