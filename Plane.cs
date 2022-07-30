namespace Practice{
    public class Plane{
        public string make;
        public string model;
        public string bodyType;

        // Constructor to make an initial plane object
        public Plane(string makeName, string modelName, string bodyName){
            make = makeName;
            model = modelName;
            bodyType = bodyName;
        }
    }
}