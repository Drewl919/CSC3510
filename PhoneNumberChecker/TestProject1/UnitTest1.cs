using PhoneNumberChecker;

namespace TestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethodValidLength10Digit() {
            string pNum = "555-121-2222";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsTrue(pn.isValidPhone());
        }
        [TestMethod]
        public void TestMethodValidLength7Digit() {
            string pNum = "121-2222";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsTrue(pn.isValidPhone());
        }
        [TestMethod]
        public void TestValid11DigitsWDashes() {
            string pNum = "121-222-3333";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsTrue(pn.isValidPhone());
        }
        [TestMethod]
        public void TestValid12Length() {
            string pNum = "121-222-3333";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsTrue(pn.isValid12Digit());
        }
        [TestMethod]
        public void TestNotValid12Length() {
            string pNum = "121-222x3333";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsFalse(pn.isValid12Digit());
        }
        [TestMethod]
        public void TestJustDigitsWithDashes() {
            string pNum = "121-222-3333";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsTrue(pn.justDigits());
        }
        [TestMethod]
        public void TestJustDigitsWithDashesBad() {
            string pNum = "121-222-33x3";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsFalse(pn.justDigits());
        }
        [TestMethod]
        public void TestJustDigitsWithDashesBad2() {
            string pNum = "121-222-33-3";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsFalse(pn.justDigits());
        }
        [TestMethod]
        public void TestBadAreaCode() {
            string pNum = "121-222-3343";
            PhoneNumber pn = new PhoneNumber(pNum);
            Assert.IsFalse(pn.validAreaCode());
        }
        //[TestMethod]
        //public void ProveTheProfWrong() {
        //    string pNum = "121-222-3323-";
        //    PhoneNumber pn = new PhoneNumber(pNum);
        //    Assert.IsFalse(pn.isValidPhone());
        //}
    }
}