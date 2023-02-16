using DepInjections_2_16;

namespace Tester;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestMethod1() {
        IWeatherData wTest = new WeatherTestData();
        Weather2 w2 = new Weather2(wTest);
        Assert.AreEqual(90, w2.getSummerHiAver());
    }
    
    [TestMethod]
    public void TestMethodWith0Data() {
        IWeatherData wTest = new Weather0Data();
        Weather2 w3 = new Weather2(wTest);
        Assert.AreEqual(0, w3.getSummerHiAver());
    }
}