namespace ReviewMT; 

public class GetDataFromList : IGestStudentData {
    public List<Student> getStudentData() {
        List<Student> sList = new List<Student>();
        List<decimal> scores = new List<decimal>();
        scores.Add(70.0m);
        scores.Add(60.0m);
        scores.Add(80m);
        sList.Add(new Student("101", scores));
        return sList;
    }
}