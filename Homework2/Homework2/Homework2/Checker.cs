namespace Homework2;

public class Checker {
    private string inPassword;

    public Checker(string inPassword) {
        this.inPassword = inPassword;
    }

    public string checkPassword() {
        // Check that inPassword is valid

        string csvRet = "0";
        List<int> rules = new List<int>();

        if (!checkLength()) {
            rules.Add(1);
        }

        if (!checkLowChars()) {
            rules.Add(2);
        }
        
        //Check for a valid password using the following rules:
        // 1 Must be at least 8 characters in length
        // 2 Must contain at least 1 upper character
        // 3 Must contain at least 1 lower case character
        // 4 Must contain at least one of these characters *&^!$
        //        but they must not be in the last position of the string
        // 5 It must contain at least 2 digits
        // 6 It may not contain one of these words: max, bank, money, cash
        //
        //Returns a string that indicates each of the above rule violation CSV
        //For example if inPassword
        // a. is valid except for rule 1 return "1"
        // b. is valid except for rule 1 and 3 return "1,3"
        // c. is valid except for rule 1, 4, and 5 return "1,4,5"
        // d. is valid return "0"
        //Write this method
        //Include tests to achieve 100% statement coverage
        //Use TDD
        // -Hand in at least 3 screen shots that shows you are using TDD
        // -Hand in a screen shot that shows the code passing all tests

        return csvRet;
    }

    public bool checkLowChars() {
        if (inPassword.Any(char.IsLower)) {
            return true;
        }
        return false;
    }

    public bool checkLength() {
        if (inPassword.Length >= 8) {
            return true;
        }
        return false;
    }
}