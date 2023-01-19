using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1_19 {
    public class Inventory {
        //Hammer,22,5.99
        public string item;
        public int count;
        public decimal price;

        public Inventory(string item, int count, decimal price) {
            this.item = item;
            this.count = count;
            this.price = price;
        }
    }
}
