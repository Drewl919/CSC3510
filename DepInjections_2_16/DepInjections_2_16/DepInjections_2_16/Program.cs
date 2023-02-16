// See https://aka.ms/new-console-template for more information

using DependInjection;
using DependInjectionl;
using DepInjections_2_16;

Console.WriteLine("Hello, World!");
// DBConnect DB = new DBConnect();
// List<HiPerMonth> hiPerMonths = DB.SelectWeatherRecords();
//
// foreach (HiPerMonth hpm in hiPerMonths) {
//     Console.WriteLine("\n Row:{0}", hpm.ToString());
// }

Weather w1 = new Weather();
Console.WriteLine("Summer Aver:{0}", w1.getSummerHiAver());

Console.WriteLine("\n --------------------------");
IWeatherData wfdb = new WeatherFromDB();
IWeatherData wTest = new WeatherTestData();
Weather2 w2 = new Weather2( wTest );
Console.WriteLine("FL2 : Summer Aver:{0}", w2.getSummerHiAver());
