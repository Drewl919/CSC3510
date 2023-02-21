using DepInjections_2_16;

namespace Tester;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestMethod1() {
        IWeatherData wTest = new WeatherTestData();
        Weather2 w2 = new Weather2(wTest);
        Assert.AreEqual(75, w2.getSummerHiAver());
        Assert.AreEqual(90, w2.getSummerHiAver());
        // Console.WriteLine("\n Summer2 Aver:{0}", w2.getSummerHiAver());

    }
    
    [TestMethod]
    public void TestMethodWith0Data() {
        IWeatherData wTest = new Weather0Data();
        Weather2 w3 = new Weather2(wTest);
        Assert.AreEqual(0, w3.getSummerHiAver());
    }
    
    [TestMethod]
    public void TestMethodInjection() {
        IWeatherData wd3 = new WeatherTestData();
        WeatherMethodInjection w2 = new WeatherMethodInjection();
        double summerAver = w2.getSummerHiAver(wd3);
        Assert.AreEqual(75, summerAver);
    }
}