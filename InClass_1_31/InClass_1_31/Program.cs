// See https://aka.ms/new-console-template for more information
using InClass_1_31;

Console.WriteLine("Hello, World!");

DBConnectMysql dbc = new DBConnectMysql();

List<Candy> candyList = dbc.Select();

foreach(Candy candy in candyList) {
    Console.WriteLine("Id:{0} Item:{1}", candy.id, candy.item);
}

//dbc.Insert("Toblerone", 100, 10.99m);

Console.WriteLine("OK for now!");
Console.ReadLine();