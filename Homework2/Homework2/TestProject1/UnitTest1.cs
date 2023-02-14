using Homework2;

namespace TestProject1;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestCheckLengthMethodTooShort() {
        Checker c = new Checker("pass");
        Assert.IsFalse(c.checkLength());
    }
    [TestMethod]
    public void TestCheckLengthMethodExactly8() {
        Checker c = new Checker("password");
        Assert.IsTrue(c.checkLength());
    }
    [TestMethod]
    public void TestCheckLengthMethodLongerThan8() {
        Checker c = new Checker("longpassword");
        Assert.IsTrue(c.checkLength());
    }
    [TestMethod]
    public void TestLowerCharsMethodNone() {
        Checker c = new Checker("PASSWORD");
        Assert.IsFalse(c.checkLowChars());
    }
    [TestMethod]
    public void TestLowerCharsMethodAll() {
        Checker c = new Checker("password");
        Assert.IsTrue(c.checkLowChars());
    }
    [TestMethod]
    public void TestLowerCharsMethodMixed() {
        Checker c = new Checker("PaSsWoRd");
        Assert.IsTrue(c.checkLowChars());
    }
    
    
}