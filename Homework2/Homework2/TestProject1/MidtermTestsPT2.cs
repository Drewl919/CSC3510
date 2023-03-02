// Andrew Musielak
// CSC3510

using Homework2;
using MTProblem1;

namespace TestProject1;

[TestClass]
public class MidtermTestsPT2 {
    [TestMethod]
    public void TestTaxesTotal() {
        // Test Case 1 - Testing Total taxes
        // Result - Failed - Bug, because at exactly 100,000, the taxes due should be 15% of gross, but since the equality is less than 100,000 and the following is greater than 100,000, the method resorts to the default tax of 10%
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(94149.95m, taxes);
    }
    [TestMethod]
    public void TestTaxesForLess() {
        // Test Case 2 - Testing taxes for 49,999, being less than 50,000 returns 10% taxes
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(4999.90m, taxes);
    }
    [TestMethod]
    public void TestTaxesExactly50() {
        // Test Case 3 - Testing taxes for exactly 50,000 returns 15% taxes
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(7500m, taxes);
    }
    [TestMethod]
    public void TestTaxesJustAbove50() {
        // Test Case 4 - Testing taxes for exactly 51,000, just above 50,000 returns 15% taxes
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(7650m, taxes);
    }
    [TestMethod]
    public void TestTaxesJustUnder100() {
        // Test Case 5 - Testing taxes at 99,999, just under the 100,000 threshold for 15%
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(14999.85m, taxes);
    }
    [TestMethod]
    public void TestTaxesExactly100() {
        // Test Case 6 - Testing taxes at 100,000 returns 15% taxes
        // Result - Passed - Bug, because 100,000 should have returned a taxes of 15%, not 10%, but since 100,000 is not included but rather just less than 100,000 in the second tax section, it never gets the 15% tax assigned.
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(15000m, taxes);
    }
    [TestMethod]
    public void TestTaxesJustAbove100() {
        // Test Case 7 - Testing taxes at 100,001 returns 20% taxes
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(20000.2m, taxes);
    }
    [TestMethod]
    public void TestTaxesAbove100() {
        // Test Case 8 - Testing taxes at 120,000 returns 20% taxes
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(24000m, taxes);
    }
    [TestMethod]
    public void TestTaxesCombinationOfMid() {
        // Test Case 9 - Testing a combination of taxes that fall in the middle of 50,000 and 100,000 boundary (2, 3, and 4)
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(30149.85m, taxes);
    }
    [TestMethod]
    public void TestTaxesOneFromEach() {
        // Test Case 10 - Testing tax forms from each section and checking the total (1, 4, and 7)
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(43999.75m, taxes);
    }
    [TestMethod]
    public void TestTaxesMultiCombo() {
        // Test Case 11 - Testing a combination of tax forms, pulling multiple from each section (1, 3, 4, 6, and 7)
        // Result - Passed - No bugs found
        IGetData gt = new TaxCheckerTestData();
        TaxChecker tc = new TaxChecker(gt);
        decimal taxes = tc.processTaxForms();
        Assert.AreEqual(71649.95m, taxes);
    }
}