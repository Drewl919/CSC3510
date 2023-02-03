

using ExerciseApp;
using System.ComponentModel.DataAnnotations.Schema;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
string inFile = path + "\\..\\input\\exercises.txt";
//Console.WriteLine(inFile);

CalorieBurner cb = new CalorieBurner(inFile);
cb.getRowsFromFile();
cb.SetExerciseRecords();

string exType;
DateTime dt;

while (true) {
    Console.WriteLine("Choose an activity (walking or biking) or total:");
    exType = Console.ReadLine();
    if(exType.ToLower() is "walking" or "biking" or "total") {
        while(true) {
            Console.WriteLine("Specify a date to view (yyyy-mm-dd):");
            try {
                dt = Convert.ToDateTime(Console.ReadLine());
                break;
            } catch(Exception ex) {
                Console.WriteLine("Not a valid date format (yyyy-mm-dd)");
            }
        }
        break;
    } else {
        Console.WriteLine("Not a valid activity option");
    }
}


if(exType.ToLower() == "walking") {
    Console.WriteLine("Calories burned while walking on {0} was {1}", dt.ToShortDateString(), cb.getWalkingCalories(dt));
} else if (exType.ToLower() == "biking") {
    Console.WriteLine("Calories burned while biking on {0} was {1}", dt.ToShortDateString(), cb.getBikingCalories(dt));
} else {
    Console.WriteLine("Total calories burned on {0} was {1}", dt.ToShortDateString(), (cb.getWalkingCalories(dt)+cb.getBikingCalories(dt)));
}


