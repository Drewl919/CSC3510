using System.Reflection;
using ExerciseApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Andrew Musielak
// CSC3510

namespace ExerciseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCanReadRows()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            Assert.AreEqual(19, cb.getRows().Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error on file open")]
        public void TestValidPath()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\exercisesfds.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }

        [TestMethod]
        public void TestSetExerciseRecords()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(18, cb.exerData.Count());
        }

        [TestMethod]
        public void TestValidDates()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual("1/1/2023", cb.exerData[1].dt.ToShortDateString());
            Assert.AreEqual("1/15/2023", cb.exerData[17].dt.ToShortDateString());
            Assert.AreEqual("1/6/2023", cb.exerData[7].dt.ToShortDateString());
        }
        [TestMethod]
        public void TestInvalidDatesAreNotEqual() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreNotEqual("2023-1-1", cb.exerData[1].dt.ToShortDateString());
            Assert.AreNotEqual("2023-1-15", cb.exerData[17].dt.ToShortDateString());
            Assert.AreNotEqual("2023-1-6", cb.exerData[7].dt.ToShortDateString());
            Assert.AreNotEqual("2023/1/1", cb.exerData[1].dt.ToShortDateString());
            Assert.AreNotEqual("2023/1/15", cb.exerData[17].dt.ToShortDateString());
            Assert.AreNotEqual("2023/1/6", cb.exerData[7].dt.ToShortDateString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Date format is not right")]
        public void TestSetValidDate()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Date_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Type format is not right")]
        public void TestSetValidType()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Type_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Time format is not right")]
        public void TestSetValidTime()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Time_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Speed format is not right")]
        public void TestSetValidSpeed()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Speed_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetValidMissingPar()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Missing_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
        }
        [TestMethod]
        public void TestGetWalkingCaloriesMax()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(3750m, cb.getWalkingCalories(new DateTime(2023, 1, 1)));
            Assert.AreEqual(3750m, cb.getWalkingCalories(new DateTime(2023, 1, 15)));
        }
        [TestMethod]
        public void TestGetWalkingCaloriesMid()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(4000m, cb.getWalkingCalories(new DateTime(2023, 1, 10)));
            Assert.AreEqual(3000m, cb.getWalkingCalories(new DateTime(2023, 1, 12)));
        }
        [TestMethod]
        public void TestGetWalkingCaloriesMin()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path + "\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(2700m, cb.getWalkingCalories(new DateTime(2023, 1, 3)));
            Assert.AreEqual(5400m, cb.getWalkingCalories(new DateTime(2023, 1, 14)));
        }
        [TestMethod]
        public void TestGetWalkingCaloriesNegSpeed() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(0m, cb.getWalkingCalories(new DateTime(2023, 1, 11)));
        }
        [TestMethod]
        public void TestGetWalkingCaloriesNegTime() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(0m, cb.getWalkingCalories(new DateTime(2022, 1, 2)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesLight() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(900m, cb.getBikingCalories(new DateTime(2023, 1, 16)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesModerate() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(1350m, cb.getBikingCalories(new DateTime(2023, 1, 1)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesVigorous() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(3300m, cb.getBikingCalories(new DateTime(2023, 1, 8)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesRacing() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(3900m, cb.getBikingCalories(new DateTime(2023, 1, 5)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesNegSpeed() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(0m, cb.getBikingCalories(new DateTime(2023, 1, 12)));
        }
        [TestMethod]
        public void TestGetBikingCaloriesNegTime() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inFile = path+"\\..\\..\\ExerciseApp\\input\\Test_Extremes_exercises.txt";
            CalorieBurner cb = new CalorieBurner(inFile);
            cb.getRowsFromFile();
            cb.SetExerciseRecords();
            Assert.AreEqual(0m, cb.getBikingCalories(new DateTime(2023, 1, 13)));
        }
    }
}