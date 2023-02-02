using ExerciseApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciseTests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestCanReadRows() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            Assert.AreEqual(19, cb.getRows().Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error on file open")]
        public void TestValidPath() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\ExerciseApp\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.SetExerciseRecords();
        }

        [TestMethod]
        public void TestSetExerciseRecords() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(18, cb.exerData.Count());
        }

        [TestMethod]
        public void TestValidDates() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual("1/1/2023", cb.exerData[1].dt.ToShortDateString());
            Assert.AreEqual("1/15/2023", cb.exerData[17].dt.ToShortDateString());
            Assert.AreEqual("1/6/2023", cb.exerData[7].dt.ToShortDateString());

            Assert.AreNotEqual("2023-1-1", cb.exerData[1].dt.ToShortDateString());
            Assert.AreNotEqual("2023-1-15", cb.exerData[17].dt.ToShortDateString());
            Assert.AreNotEqual("2023-1-6", cb.exerData[7].dt.ToShortDateString());

            Assert.AreNotEqual("2023/1/1", cb.exerData[1].dt.ToShortDateString());
            Assert.AreNotEqual("2023/1/15", cb.exerData[17].dt.ToShortDateString());
            Assert.AreNotEqual("2023/1/6", cb.exerData[7].dt.ToShortDateString());
        }

        //[TestMethod]
        //public void TestWalkingCaloriesCheckState() {
        //    String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //    string inFile = path + "\\..\\..\\ExerciseApp\\exercises.txt";
        //    CalorieBurner cb = new CalorieBurner(inFile);
        //    cb.getRowsFromFile();
        //    cb.SetExerciseRecords();
        //    //decimal cals = 0.0m;
        //    //Exercise ex = null;
        //    //foreach(Exercise exer in this.exerData) {
        //    //    if(exer.dt == inDate && exer.exType.ToLower() == "walking") {
        //    //        ex = exer;
        //    //        break;
        //    //    }
        //    //}

        //    Assert.


        //}


        //[TestMethod]
        //public void TestGetWalkingCalories() {
        //    String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //    string inFile = path + "\\..\\..\\ExerciseApp\\exercises.txt";
        //    CalorieBurner cb = new CalorieBurner(inFile);
        //    cb.getRowsFromFile();
        //    cb.SetExerciseRecords();



        //}
    }
}