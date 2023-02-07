using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberChecker {
    public class PhoneNumber {
        private string phoneNumber;

        public PhoneNumber(string phoneNumber) {
            this.phoneNumber = phoneNumber;
        }

        public bool isValidPhone() {
            bool isValid = false;
            if (phoneNumber.Length == 12) {
                if(!isValid12Digit()) {
                    if (!this.justDigits()) {
                        return false;
                    }
                }
                if (!validAreaCode()) {
                    return false;
                }
            } else {
                Console.WriteLine("HUH?");
            }
            if (isValidLength()) {
                return true;
            }
            return isValid;
        }

        public bool validAreaCode() {
            char digit1 = phoneNumber[0];
            if (digit1 == '0' || digit1 == '1') {
                return false;
            }
            return char.IsDigit(digit1);
        }

        public bool justDigits() {
            string pNum = phoneNumber.Replace("-", "");
            if(pNum.Length != 10) return false;
            foreach (char c in pNum) {
                if (!char.IsDigit(c)) {
                    return false;
                }
            }
            return true;
        }

        public bool isValid12Digit() {
            //string pNum = "121-222-3333";

            int ct = 0;
            foreach (char c in phoneNumber) {
                if (ct == 3 || ct == 7) {
                    if (c != '-') {
                        return false;
                    }
                }
                ct++;
            }
            return true;
        }

        private bool isValidLength() {
            string pNum = phoneNumber.Replace("-", "");
            if(pNum.Length == 7 || pNum.Length == 10) {
                return true;
            } else {
                return false;
            }
        }
    }
}
