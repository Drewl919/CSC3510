using CreditCardEvaluation;
using Moq;

namespace ApplicationTest;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestMethod1() {
        IFrequentFlyerValidate ffv = new FrequentFlyerEvaluator();
        CreditCardApplication cca = new CreditCardApplication();
        cca.GrossAnnualIncome = 100_001;
        
        CreditCardAppEvaluator sut = new CreditCardAppEvaluator(ffv);
        ApplicationDecision decision = sut.Evaluate(cca);
        Assert.AreEqual(ApplicationDecision.AutoAccepted, decision);
    }

    [TestMethod]
    public void DeclineLowIncome() {
        Mock<IFrequentFlyerValidate> mockValidator = new Mock<IFrequentFlyerValidate>();
        
        CreditCardApplication cca = new CreditCardApplication();
        cca.GrossAnnualIncome = 19_999;
        cca.Age = 125;
        
        CreditCardAppEvaluator sut = new CreditCardAppEvaluator(mockValidator.Object);
        ApplicationDecision decision = sut.Evaluate(cca);
        
        Assert.AreEqual(ApplicationDecision.AutoDeclined, decision);

    }
}