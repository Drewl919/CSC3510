// Andrew Musielak
// CSC3510

using Homework2;
using MTProblem1;

namespace TestProject1;

[TestClass]
public class MidtermTestsPT1 {
    [TestMethod]
    public void TestSSNLengthLessThan9() {
        // Test Case 1 - Testing for length less than 9 returns false
        // Result - Failed - Bug, should have passed, because we are testing that length is less than 9, which is true. Under the current situation, a SSN of 8 digits or less would be considered valid 
        TaxForm tf = new TaxForm("87639474", 21000m);
        Assert.IsFalse(tf.validSSN());
    }
    [TestMethod]
    public void TestSSNLengthExactly9() {
        // Test Case 2 - Testing for length is 9 returns true
        // Result - Passed - No bug found
        TaxForm tf = new TaxForm("876394742", 21000m);
        Assert.IsTrue(tf.validSSN());
    }
    [TestMethod]
    public void TestSSNLengthGreaterThan9() {
        // Test Case 3 - Testing for length greater than 9 returns false
        // Result - Passed - No bug found
        TaxForm tf = new TaxForm("8763947428", 21000m);
        Assert.IsFalse(tf.validSSN());
    }
    [TestMethod]
    public void TestSSNHas0() {
        // Test Case 4 - Testing for 0s in SSN return false
        // Result - failed - Bug, because all of these SSNs contain 0 and should be returning false, not true. However, because in the code it is testing to see if the SSN is a number within the loop, only the first digit of the SSN is actually checked.
        TaxForm tf1 = new TaxForm("807132846", 21000m);
        Assert.IsFalse(tf1.validSSN());
        TaxForm tf2 = new TaxForm("830132846", 21000m);
        Assert.IsFalse(tf2.validSSN());
        TaxForm tf3 = new TaxForm("837032846", 21000m);
        Assert.IsFalse(tf3.validSSN());
        TaxForm tf4 = new TaxForm("837102846", 21000m);
        Assert.IsFalse(tf4.validSSN());
        TaxForm tf5 = new TaxForm("837130846", 21000m);
        Assert.IsFalse(tf5.validSSN());
        TaxForm tf6 = new TaxForm("837132046", 21000m);
        Assert.IsFalse(tf6.validSSN());
        // tf7 passes because it triggers the return false statement before going into the section that is the bug.
        TaxForm tf7 = new TaxForm("037132846", 21000m);
        Assert.IsFalse(tf7.validSSN());
        TaxForm tf8 = new TaxForm("837132840", 21000m);
        Assert.IsFalse(tf8.validSSN());
    }
    [TestMethod]
    public void TestSSNHasNo0() {
        // Test Case 5 - Test for no 0s in SSN return true
        // Result - Passed - No bug found
        TaxForm tf = new TaxForm("837969127", 21000m);
        Assert.IsTrue(tf.validSSN());
    }
    [TestMethod]
    public void TestSSNFor666InFirst3() {
        // Test Case 6 - Testing for 666 in first three digits returns false
        // Result - Passed - No bug found
        TaxForm tf = new TaxForm("666849827", 21000m);
        Assert.IsFalse(tf.validSSN());
    }
    [TestMethod]
    public void TestSSNFor666InDifferentSpots() {
        // Test Case 7 - Testing for 666 not in first three digits return true
        // Result - Passed - No bug found
        TaxForm tf1 = new TaxForm("837666286", 21000m);
        Assert.IsTrue(tf1.validSSN());
        TaxForm tf2 = new TaxForm("126668399", 21000m);
        Assert.IsTrue(tf2.validSSN());
        TaxForm tf3 = new TaxForm("937574666", 21000m);
        Assert.IsTrue(tf3.validSSN());
        TaxForm tf4 = new TaxForm("166621983", 21000m);
        Assert.IsTrue(tf4.validSSN());
    }
    
    
}