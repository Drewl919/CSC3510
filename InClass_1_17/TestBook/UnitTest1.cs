
namespace TestBook;

[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestPricePerPageOKFractional() {
        Book b = new Book("Good Grief", 100, 20m, 10);
        Console.WriteLine("Expected:.2  Actual:{0}", b.PricePerPage());
        Assert.AreEqual(.2m, b.PricePerPage());
    }

    [TestMethod]
    public void TestPricePerPageOK() {
        Book b = new Book("Good Grief", 100, 200m, 10);
        Console.WriteLine("Expected:2  Actual:{0}", b.PricePerPage());
        Assert.AreEqual(2, b.PricePerPage());
    }

    [TestMethod]
    public void TestPricePerPageZero() {
        Book b = new Book("Good Grief", 0, 100m, 10);
        Console.WriteLine("Expected:0  Actual:{0}", b.PricePerPage());
        Assert.AreEqual(0m, b.PricePerPage());
    }

    [TestMethod]
    public void TestNoReOrder() {
        Book b = new Book("Good Grief", 100, 100m, 1000);
        Console.WriteLine("Expected:false  Actual:{0}", b.reOrder());
        Assert.IsFalse(b.reOrder());
    }

    [TestMethod]
    public void TestReOrder100Price() {
        Book b = new Book("Good Grief", 100, 100m, 10);
        Console.WriteLine("Expected:true  Actual:{0}", b.reOrder());
        Assert.IsTrue(b.reOrder());
    }

    [TestMethod]
    public void TestReOrder50Price() {
        Book b = new Book("Good Grief", 100, 100m, 10);
        Console.WriteLine("Expected:true  Actual:{0}", b.reOrder());
        Assert.IsTrue(b.reOrder());
    }

    [TestMethod]
    public void TestReOrder50Count() {
        Book b = new Book("Good Grief", 100, 60m, 30);
        Console.WriteLine("Expected:false  Actual:{0}", b.reOrder());
        Assert.IsFalse(b.reOrder());
    }

    [TestMethod]
    public void TestReOrder10Price() {
        Book b = new Book("Good Grief", 100, 10m, 49);
        Console.WriteLine("Expected:true  Actual:{0}", b.reOrder());
        Assert.IsTrue(b.reOrder());
    }
}
