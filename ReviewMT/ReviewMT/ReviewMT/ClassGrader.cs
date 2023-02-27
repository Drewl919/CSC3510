namespace ReviewMT;

public class ClassGrader{
    private List<Student> students = null;
    // 0. Practice TDD for this exercise. What are the steps?
    // 1.Write code to get students. DId you already create the test class? 
    // 2. Implement getAverage
    // 2.b Create the equivalence partition for this class
    //   c Create a boundary valuation
    //   d. List test cases and why you selected them
    //  2.c Create test 2 test cases for this data
    // 3. Rewrite the getStudents() method to inject an interface into the 
    //    getStudents method:
    //    E.g., 
    //       private List<Student> getStudents( IGetStudentData getData ).
    // 4. Write test cases to test this data.
    public ClassGrader(IGestStudentData studentData) {
        this.students = studentData.getStudentData();
    }

    public decimal getOverallAverage(){
        decimal retVal = 0.0m;
        // get the overall average for these students
        return retVal;
    }

    public decimal getStudentAverage( string studentID){
        // For a given student ID return their average
        // if overall grade is > 100 set it to 100
        // If overall grade is < 0 set it to 0
        decimal aver = 0.0m;
        return aver;
    }
    private List<Student> getStudents(IGestStudentData studentData) {
        return studentData.getStudentData();
        // Generate this list of students 
        // 101 -> 
        //    HWScores = 70, 60, 80;
        // 102 -> 
        //    HWScores = 40, 55, 75;
        // 103 -> 
        //    HWScores = 100, 90, 80;
    }
}