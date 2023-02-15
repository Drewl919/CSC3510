// Andrew Musielak
// CSC3510

using Homework2;

namespace TestProject1;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestCheckLengthTooShort() {
        Checker c = new Checker("pass");
        Assert.IsTrue(c.checkPassword().Contains('1'));
    }
    [TestMethod]
    public void TestCheckLengthExactly8() {
        Checker c = new Checker("password");
        Assert.IsFalse(c.checkPassword().Contains('1'));
    }
    [TestMethod]
    public void TestCheckLengthLongerThan8() {
        Checker c = new Checker("longpassword");
        Assert.IsFalse(c.checkPassword().Contains('1'));
    }
    
    [TestMethod]
    public void TestCheckForUpperCaseNone() {
        Checker c = new Checker("password");
        Assert.IsTrue(c.checkPassword().Contains('2'));
    }
    [TestMethod]
    public void TestCheckForUpperCaseAll() {
        Checker c = new Checker("PASSWORD");
        Assert.IsFalse(c.checkPassword().Contains('2'));
    }
    [TestMethod]
    public void TestCheckForUpperCaseMixed() {
        Checker c = new Checker("PaSsWoRd");
        Assert.IsFalse(c.checkPassword().Contains('2'));
    }
    
    [TestMethod]
    public void TestCheckForLowerCaseNone() {
        Checker c = new Checker("PASSWORD");
        Assert.IsTrue(c.checkPassword().Contains('3'));
    }
    [TestMethod]
    public void TestCheckForLowerCaseAll() {
        Checker c = new Checker("password");
        Assert.IsFalse(c.checkPassword().Contains('3'));
    }
    [TestMethod]
    public void TestCheckForLowerCaseMixed() {
        Checker c = new Checker("PaSsWoRd");
        Assert.IsFalse(c.checkPassword().Contains('3'));
    }

    [TestMethod]
    public void TestCheckForSpecialChar1() {
        Checker c = new Checker("pass*word");
        Assert.IsFalse(c.checkPassword().Contains('4'));
    }
    [TestMethod]
    public void TestCheckForSpecialChar2() {
        Checker c = new Checker("pass&word");
        Assert.IsFalse(c.checkPassword().Contains('4'));
    }
    [TestMethod]
    public void TestCheckForSpecialChar3() {
        Checker c = new Checker("pass^word");
        Assert.IsFalse(c.checkPassword().Contains('4'));
    }
    
    [TestMethod]
    public void TestCheckForSpecialChar4() {
        Checker c = new Checker("pass!word");
        Assert.IsFalse(c.checkPassword().Contains('4'));
    }
    
    [TestMethod]
    public void TestCheckForSpecialChar5() {
        Checker c = new Checker("pass$word");
        Assert.IsFalse(c.checkPassword().Contains('4'));
    }
    [TestMethod]
    public void TestCheckForSpecialCharLastPos() {
        Checker c1 = new Checker("password*");
        Assert.IsTrue(c1.checkPassword().Contains('4'));
        Checker c2 = new Checker("password&");
        Assert.IsTrue(c2.checkPassword().Contains('4'));
        Checker c3 = new Checker("password^");
        Assert.IsTrue(c3.checkPassword().Contains('4'));
        Checker c4 = new Checker("password!");
        Assert.IsTrue(c4.checkPassword().Contains('4'));
        Checker c5 = new Checker("password$");
        Assert.IsTrue(c5.checkPassword().Contains('4'));
    }
    [TestMethod]
    public void TestCheckForSpecialCharNone() {
        Checker c = new Checker("password");
        Assert.IsTrue(c.checkPassword().Contains('4'));
    }
    
    [TestMethod]
    public void TestCheckFor2DigitsNone() {
        Checker c = new Checker("password");
        Assert.IsTrue(c.checkPassword().Contains('5'));
    }
    [TestMethod]
    public void TestCheckFor2DigitsExactly() {
        Checker c = new Checker("password36");
        Assert.IsFalse(c.checkPassword().Contains('5'));
    }
    [TestMethod]
    public void TestCheckFor2DigitsMore() {
        Checker c = new Checker("password8374");
        Assert.IsFalse(c.checkPassword().Contains('5'));
    }
    [TestMethod]
    public void TestCheckFor2DigitsTogether() {
        Checker c = new Checker("pas23sword");
        Assert.IsFalse(c.checkPassword().Contains('5'));
    }
    [TestMethod]
    public void TestCheckFor2DigitsMixed() {
        Checker c = new Checker("pa5ssw8ord");
        Assert.IsFalse(c.checkPassword().Contains('5'));
    }
    
    
    [TestMethod]
    public void TestCheckForBlackWordMax() {
        Checker c1 = new Checker("passmaxword");
        Assert.IsTrue(c1.checkPassword().Contains('6'));
        Checker c2 = new Checker("passMaXword");
        Assert.IsTrue(c2.checkPassword().Contains('6'));
    }
    [TestMethod]
    public void TestCheckForBlackWordBank() {
        Checker c1 = new Checker("passbankword");
        Assert.IsTrue(c1.checkPassword().Contains('6'));
        Checker c2 = new Checker("passBaNkword");
        Assert.IsTrue(c2.checkPassword().Contains('6'));
    }
    [TestMethod]
    public void TestCheckForBlackWordMoney() {
        Checker c1 = new Checker("passmoneyword");
        Assert.IsTrue(c1.checkPassword().Contains('6'));
        Checker c2 = new Checker("passMoNeYword");
        Assert.IsTrue(c2.checkPassword().Contains('6'));
    }
    [TestMethod]
    public void TestCheckForBlackWordCash() {
        Checker c1 = new Checker("passcashword");
        Assert.IsTrue(c1.checkPassword().Contains('6'));
        Checker c2 = new Checker("passCaShword");
        Assert.IsTrue(c2.checkPassword().Contains('6'));
    }
    [TestMethod]
    public void TestCheckForBlackWordNone() {
        Checker c1 = new Checker("password");
        Assert.IsFalse(c1.checkPassword().Contains('6'));
    }
    
    [TestMethod]
    public void TestValidPasswords() {
        Checker c1 = new Checker("Pas$word15");
        Assert.IsTrue(c1.checkPassword().Contains('0'));
        Checker c2 = new Checker("C0mp&ny4");
        Assert.IsTrue(c2.checkPassword().Contains('0'));
        Checker c3 = new Checker("ThisIsAR3a!lyL0ngPassw0rd");
        Assert.IsTrue(c3.checkPassword().Contains('0'));
        Checker c4 = new Checker("Test*ngbo34undari3s");
        Assert.IsTrue(c4.checkPassword().Contains('0'));
    }
}