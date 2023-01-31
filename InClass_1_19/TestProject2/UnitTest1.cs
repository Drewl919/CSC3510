using InClass_1_19;

namespace TestProject2 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestCanReadRows() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine("Path:{0}", path);
            string inFile = path + "\\..\\..\\Inclass_1_19\\input\\inventory.txt";
            Console.WriteLine("inFile:{0}", inFile);
            InventManager im = new InventManager(inFile);
            im.setDataFromFile();
            String[] rows = im.getDataRows();
            Console.WriteLine("RL:{0} ", rows.Length);
            Assert.AreEqual(6, rows.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Price not right")]
        public void TestBadPrice() {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine("Path:{0}", path);
            string inFile = path + "\\..\\..\\Inclass_1_19\\input\\Test1_Inventory.txt";
            Console.WriteLine("inFile:{0}", inFile);
            InventManager im = new InventManager(inFile);
            im.setDataFromFile();
            im.parseRows();

        }
    }
}