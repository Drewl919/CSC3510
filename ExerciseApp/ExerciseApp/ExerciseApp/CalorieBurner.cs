using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Andrew Musielak
// CSC3510

namespace ExerciseApp {
    public class CalorieBurner {
        public string inFile; // The input file path and name
        public string[] rows = new string[0]; // These are the raw rows from file
        public List<Exercise> exerData = new List<Exercise>(); // These are Raw Rows converted into Exercise
        public CalorieBurner(string inFile) {
            this.inFile = inFile;
        }
        public void getRowsFromFile() {
            try {
                this.rows = File.ReadAllLines(inFile);
            } catch (Exception ex) {
                throw new ArgumentException("Error on file open");
            }
        }

        public string[] getRows() {
            return rows;
        }

        public void SetExerciseRecords() {
            List<Exercise> eData = new List<Exercise>();
            foreach (string row in this.rows) {
                if(this.rows[0] == row) {
                    continue;
                }
                string[] toks = row.Split(',');
                DateTime dt;
                string exType;
                decimal time;
                decimal speed;
                try {
                    dt = Convert.ToDateTime(toks[0]);
                } catch (Exception ex) {
                    throw new ArgumentException("Date format is not right");
                }
                if (toks[1].ToLower() is "walking" or "biking") {
                    exType = toks[1];
                } else {
                    throw new ArgumentException("Type format is not right");
                }
                try {
                    if (decimal.Parse(toks[2]) > 0) {
                        time = decimal.Parse(toks[2]);
                    } else {
                        time = 0.0m;
                    }
                } catch(Exception ex) {
                    throw new ArgumentException("Time format is not right");
                }
                try {
                    if(decimal.Parse(toks[3]) > 0) {
                        speed = decimal.Parse(toks[3]);
                    } else {
                        speed = 0m;
                    }
                } catch(Exception ex) {
                    throw new ArgumentException("Speed format is not right");
                }
                eData.Add(new Exercise(dt, exType, time, speed));
            }
            this.exerData = eData;
        }
        public decimal getWalkingCalories(DateTime inDate) {
            decimal cals = 0.0m;
            Exercise ex = null;
            foreach (Exercise exer in this.exerData) {
                if(exer.dt == inDate && exer.exType.ToLower() == "walking") {
                    ex = exer;
                    break;
                }
            }
            if(ex.speed >= 3.0m) {
                cals = Decimal.Multiply(125.0m, ex.time);
            } else if(ex.speed >= 2.5m) {
                cals = Decimal.Multiply(100.0m, ex.time);
            } else if(ex.speed > 0m) {
                cals = Decimal.Multiply(90.0m, ex.time);
            } else {
                cals = 0m;
            }
            return cals;
        }
        public decimal getBikingCalories(DateTime dateTime) {
            decimal cals = 0.0m;
            Exercise ex = null;
            foreach(Exercise exer in this.exerData) {
                if(exer.dt == dateTime && exer.exType.ToLower() == "biking") {
                    ex = exer;
                    break;
                }
            }
            if(ex.speed > 0m && ex.speed < 10m) {
                cals = Decimal.Multiply(30, ex.time);
            } else if(ex.speed >= 10 && ex.speed < 14) {
                cals = Decimal.Multiply(45, ex.time);
            } else if(ex.speed >= 14 && ex.speed < 20) { 
                cals = Decimal.Multiply(55, ex.time);
            } else if (ex.speed >= 20) {
                cals = Decimal.Multiply(65, ex.time);
            } else {
                cals = 0m;
            }
            return cals;
        }
    }
}
