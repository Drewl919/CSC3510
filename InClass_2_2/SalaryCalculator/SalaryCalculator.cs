using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_2_2_Sal {
    public  class SalaryCalculator {
        private int weeks;
        public int Weeks { get { return weeks; } 
            set {
                if (value > 52 ) {
                    throw new ArgumentException("Illegal Weeks");
                } else {
                    weeks = Weeks;
                }
            } 
        }
        public SalaryCalculator( int weeks) {
            if ( weeks > 52 ) {
                throw new ArgumentException("Illegal Weeks");
            }
            this.weeks = weeks;
        }
        public decimal getAnualSalary(decimal rate) {
            if ( rate < 0) {
                rate = 0;
            }
            if ( weeks < 0 ) {
                weeks = 0;
            }
            decimal annual = rate * weeks;
            return annual;

        }

    }
}
