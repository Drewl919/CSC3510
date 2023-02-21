using DependInjection;

namespace DepInjections_2_16; 

public class WeatherMethodInjection {
    private List<HiPerMonth> HiPerMonth = null;
    private IWeatherData _weatherData;

    public WeatherMethodInjection() {
        
    }

    private void setWeatherData(IWeatherData weatherData) {
        this.HiPerMonth = weatherData.GetWeatherData();
    }

    public double getSummerHiAver(IWeatherData weatherData) {
        setWeatherData(weatherData);
        int ct = 0;
        double sum = 0;
        foreach (var rec in this.HiPerMonth) {
            
        }

        return 75;
    }
}