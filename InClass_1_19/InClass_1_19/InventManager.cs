using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1_19 {
    public class InventManager {

        public string inFile;
        public string[] rows;
        public List<Inventory> inventory = new List<Inventory>();

        public InventManager(string inFile) {
            this.inFile = inFile;
        }

        public void setDataFromFile() {
            //string[] rows = new string[0];
            try {
                this.rows = File.ReadAllLines(inFile);
            } catch (Exception e) {
                Console.WriteLine("Error on File Open");
                //console.WriteLine(e.Message);
                throw new FileNotFoundException("Error on file open");
            }
        }

        public string[] getDataRows() {
            return rows;
        }

        public void parseRows() {
            foreach (string row in this.rows) {
                string[] toks = row.Split(',');
                string item;
                int count;
                decimal price;

                try {
                    item = toks[0];
                } catch (Exception e) {
                    throw new ArgumentException("Item not right");
                }

                try {
                    count = int.Parse(toks[1]);
                } catch (Exception e) {
                    throw new ArgumentException("Count not right");
                }

                try {
                    price = decimal.Parse(toks[2]);
                } catch (Exception e) {
                    throw new ArgumentException("Price not right");
                }

                inventory.Add(new Inventory(item, count, price));
            }
        }
    }
}
