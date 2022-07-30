// Inheritance - Making a parent: Company
namespace Practice{
    public class Company{
        public string Name {set; get;}
        public bool Tech {set; get;}
        public bool Fortune500 {set; get;}

        /*
        public Company(string companyName, bool isTech, bool isFortune500){
            Name = companyName;
            Tech = isTech;
            Fortune500 = isFortune500;
        }
        */
    }

    // Child for inheritance. Inherited from Company
    public class Department : Company{
        public string DepartmentName {set; get;}
        public string DepartmentHead {set; get;}
        public int DepartmentBudget {set; get;}
        public Department(string departmentName, string departmentHead, int departmentBudget){
            
            DepartmentName = departmentName;
            DepartmentHead = departmentHead;
            DepartmentBudget = departmentBudget;
            
        }
    }
}