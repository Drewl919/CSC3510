using DependInjection;

namespace DepInjections_2_16; 

public class WeatherTestData : IWeatherData {
    public List<HiPerMonth> GetWeatherData() {
        List<HiPerMonth> hpm = new List<HiPerMonth>();
        hpm.Add(new HiPerMonth(0, 0, 0, 0, 0, 100, 90, 80, 0, 0, 0, 0, 2000));
        hpm.Add(new HiPerMonth(0, 0, 0, 0, 0, 100, 90, 80, 0, 0, 0, 0, 2000));
        return hpm;
    }
}