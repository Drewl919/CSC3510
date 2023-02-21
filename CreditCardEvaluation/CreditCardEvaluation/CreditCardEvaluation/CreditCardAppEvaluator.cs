namespace CreditCardEvaluation; 

public class CreditCardAppEvaluator {
    private const int AutoRefMaxAge = 20;
    private const int HighIncomeThreshold = 100_000;
    private const int LowIncomeThreshold = 20_000;
    private readonly IFrequentFlyerValidate _validate;

    public CreditCardAppEvaluator(IFrequentFlyerValidate ffValidate) {
        _validate = ffValidate;
    }

    public ApplicationDecision Evaluate(CreditCardApplication application) {
        if (application.GrossAnnualIncome > HighIncomeThreshold) {
            return ApplicationDecision.AutoAccepted;
        }
        if (application.GrossAnnualIncome < LowIncomeThreshold) {
            return ApplicationDecision.AutoDeclined;
        }

        if (application.Age <= AutoRefMaxAge) {
            return ApplicationDecision.ReferredToHuman;
        }

        return ApplicationDecision.ReferredToHuman;
    }
}