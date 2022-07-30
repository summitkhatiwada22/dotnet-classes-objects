// Encapsulation Practice
// Encapsulation is using set and get method to keep the inner code inaccessible
// We use set and get to access the class fields
namespace Practice{
    public class Motorbike{
        public string Company {set; get;}
        public string Model {set; get;}
        public int Odometer {set; get;}

        // Creating a constructor
        public Motorbike(string companyName, string modelName, int odometerReading){
            Company = companyName;
            Model = modelName;
            Odometer = odometerReading;
        }
    }
}