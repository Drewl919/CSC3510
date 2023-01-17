public class Book {
    public string title;
    public int pages;
    public decimal price;
    public int count;

    public Book(string tile, int pages, decimal price, int count) {
        this.title = title;
        this.pages = pages;
        this.price = price;
        this.count = count;
    }
    public decimal PricePerPage() {
        decimal ppp = 0.0m;
    if (pages <= 0) { ppp = 0;  }
    else {
        ppp = price / pages;
    }
        return ppp;
    }
    public bool reOrder() {
        bool ret = false;
        if (price >= 100 && count <= 10) {
            ret = true;
        } else if (price >= 50 && count <= 20) {
            ret = true;
        } else if (price >= 10 && count <= 50) {
            ret = true;
        }
        return ret;

    }
}