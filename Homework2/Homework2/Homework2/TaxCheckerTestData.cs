using MTProblem1;

namespace Homework2; 

public class TaxCheckerTestData : IGetData{
    public List<TaxForm> getTaxForms() {
        List<TaxForm> tForm = new List<TaxForm>();
        tForm.Add( new TaxForm("222334442", 49_999));
        //tForm.Add( new TaxForm("112331234", 50_000));
        tForm.Add( new TaxForm("222331211", 51_000));
        tForm.Add( new TaxForm("123456789", 99_999));
        //tForm.Add( new TaxForm("123456777", 100_000));
        tForm.Add( new TaxForm("123456772", 100_001 ));
        tForm.Add( new TaxForm("123456773", 120_000));
        return tForm;
    }
}