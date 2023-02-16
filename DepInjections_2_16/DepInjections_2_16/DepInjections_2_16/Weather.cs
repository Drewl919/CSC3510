using DependInjection;
using DependInjectionl;

namespace DepInjections_2_16; 

public class Weather {
    public List<HiPerMonth> HiPerMonths { get; set; }

    public Weather() {
        DBConnect DB = new DBConnect();
        this.HiPerMonths = DB.SelectWeatherRecords();
    }

    public double getSummerHiAver() {
        double aver = 0.0;
        var ct = 0;
        double sum = 0.0;
        foreach (var row in HiPerMonths) {
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