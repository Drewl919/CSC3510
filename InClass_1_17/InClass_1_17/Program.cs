// See https://aka.ms/new-console-template for more information
//using InClass_1_17;

Console.WriteLine("Hello, World!");

List<Book> books = getBooksFromUser();
Console.WriteLine("Size:{0}", books.Count);

foreach(Book book in books) {
    Console.WriteLine("Title:{0} P:{1} P:{2} ppp:{3}", book.title, book.pages, book.price, book.PricePerPage());
}
Console.Read();



List<Book> getBooksFromUser() {
    List<Book> books = new List<Book>();
    //string title, int pages, decimal price
    books.Add(new Book("Good Grief", 100, 20, 10));
    books.Add(new Book("Pizza is good", 150, 10.5m, 10));
    books.Add(new Book("All about nothing", 1000, 50.0m, 10));
    books.Add(new Book("Nothing ot see", 100, 23.5m, 10));
    return books;
}

//int x = 0;
//decimal pay = 53.4m;
//double mydoubl = 100.2d;

