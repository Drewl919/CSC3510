using DependInjection;

namespace DepInjections_2_16; 

public interface IWeatherData {
    List<HiPerMonth> GetWeatherData();
}