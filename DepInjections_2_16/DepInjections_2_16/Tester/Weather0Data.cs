using DependInjection;

namespace DepInjections_2_16; 

public class Weather0Data : IWeatherData {
    public List<HiPerMonth> GetWeatherData() {
        List<HiPerMonth> hpm = new List<HiPerMonth>();
        return hpm;
    }
}