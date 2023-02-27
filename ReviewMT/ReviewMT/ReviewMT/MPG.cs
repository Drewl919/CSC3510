namespace ReviewMT;

public class MPG{
    private double miles;
    private double gallons;
    private int tankCapacity;
    public MPG(double miles, double gallons, int tankCapacity){
        this.miles = miles;
        this.gallons = gallons;
        this.tankCapacity = tankCapacity;
    }

    public double getMPG(){
        // write this method. Throw IllegalArgumentException if 
        //    Gallons > tankCapacity
        // if gallons or tankCapacity are < 0 generate IllegalArgumentException
        // - Tankcapacity must be > 10 and < 60
        // - Gallons must be > 1 and less than tankcapacity
        // 1. Perform an equivalance partition analysis 
        // 2. Perform a boundary analysis
        // 3. Create  a control flow graph
        // 3.b Create a decision table
        // 4. Write tests to demonstrate 100% statement coverage
        double mpg = 0.0;

        if (gallons > tankCapacity) {
            throw new ArgumentException("There cannot be more gas than the tank can hold.");
        }
        if (gallons < 0) {
            throw new ArgumentException("There cannot be less than 0 gallons.");
        } 
        if (tankCapacity < 0) {
            throw new ArgumentException("The capacity of the tank cannot be less than 0.");
        }
        if (!(tankCapacity > 10 && tankCapacity < 60)) {
            throw new ArgumentException("Invalid tank capacity.");
        }
        if (!(gallons > 1)) {
            throw new ArgumentException("Invalid parameters");
        }

        mpg = miles / gallons;

        return mpg;
    }
    
}