using DependInjection;
using DependInjectionl;

namespace DepInjections_2_16; 

public class Weather2 {
    public List<HiPerMonth> HiPerMonths { get; set; }

    public IWeatherData weatherData {
        set {
            this.weatherData = value;
        }
        get {
            return weatherData;
        }
    }

    public Weather2(IWeatherData weatherData) {
        this.weatherData = weatherData;
        HiPerMonths = weatherData.GetWeatherData();
    }

    public double getSummerHiAver(){
        double aver = 0.0;
        var ct = 0;
        double sum = 0.0;
        foreach (var row in HiPerMonths){
            sum += row.Jun + row.Jul + row.Aug;
            ct += 3;
        }
        if (ct == 0) {
            return 0;
        } else {
            aver = sum / ct;
            return aver;
        }
    }
}