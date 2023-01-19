// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.Read();

using InClass_1_19;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
Console.WriteLine("Path:{0}", path);
string inFile = path + "\\..\\input\\inventory.txt";
InventManager im = new InventManager(inFile);
im.setDataFromFile();
im.parseRows();

string[] invent = im.getDataRows();

for(int i = 0; i<invent.Length; i++){
    Console.WriteLine("i:{0} row:{1}", i, invent[i]);
}


Console.Read();
