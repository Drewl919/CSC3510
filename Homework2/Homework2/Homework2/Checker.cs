// Andrew Musielak
// CSC3510

namespace Homework2;

public class Checker {
    private string inPassword;

    public Checker(string inPassword) {
        this.inPassword = inPassword;
    }

    public string checkPassword() {
        string csvRet = "0";
        List<int> rules = new List<int>();
        if (inPassword.Length < 8) {
            rules.Add(1);
        }
        Boolean noUpperCase = false;
        Boolean noLowerCase = false;
        Boolean validSpecial = false;
        int digits = 0;
        for (int i = 0; i < inPassword.Length; i++) {
            if (char.IsUpper(inPassword[i])) {
                noUpperCase = true;
            } else if (char.IsLower(inPassword[i])){
                noLowerCase = true;
            } else if ((inPassword[i] == '*' || inPassword[i] == '&' || inPassword[i] == '^' || inPassword[i] == '!' ||
                   inPassword[i] == '$') && i != inPassword.Length - 1) {
                validSpecial = true;
            } else if (Char.IsDigit(inPassword[i])){
                digits++;
            }
        }
        if (!noUpperCase) {
            rules.Add(2);
        }
        if (!noLowerCase) {
            rules.Add(3);
        }
        if (!validSpecial) {
            rules.Add(4);
        }
        if (digits < 2) {
            rules.Add(5);
        }
        if (inPassword.ToLower().Contains("max") || inPassword.ToLower().Contains("bank") ||
            inPassword.ToLower().Contains("money") || inPassword.ToLower().Contains("cash")) {
            rules.Add(6);
        }
        Boolean first = true;
        foreach (int i in rules) {
            if (first) {
                csvRet = i.ToString();
                first = false;
            } else {
                csvRet = csvRet + "," + i;
            }
        }
        return csvRet;
    }
}