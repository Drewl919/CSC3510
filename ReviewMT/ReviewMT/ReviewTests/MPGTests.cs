using ReviewMT;

namespace ReviewTests;

[TestClass]
public class MPGTests {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "There cannot be more gas than the tank can hold.")]
    public void TestingGallonsNotGreaterTank() {
        MPG g = new MPG(20, 10, 5);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "There cannot be less than 0 gallons.")]
    public void TestGallonsNotLessThanZero() {
        MPG g = new MPG(20, -5, 5);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "The capacity of the tank cannot be less than 0.")]
    public void TestTankCapNotLessThanZero() {
        MPG g = new MPG(20, 10, -5);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid tank capacity.")]
    public void TestingTankCapacityLessThan10() {
        MPG g = new MPG(20, 3, 9);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid tank capacity.")]
    public void TestingTankCapacity10() {
        MPG g = new MPG(20, 3, 10);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid tank capacity.")]
    public void TestingTankCapacity60() {
        MPG g = new MPG(20, 3, 60);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid tank capacity.")]
    public void TestingTankCapacityGreaterThan60() {
        MPG g = new MPG(20, 3, 61);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid parameters")]
    public void TestingGallons1() {
        MPG g = new MPG(20, 1, 30);
        g.getMPG();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid parameters")]
    public void TestingGallonsLessThan1() {
        MPG g = new MPG(20, 0.5, 30);
        g.getMPG();
    }
    
    [TestMethod]
    public void TestingValidMPG() {
        MPG g = new MPG(20, 20, 30);
        Assert.AreEqual(1, g.getMPG());
    }
}