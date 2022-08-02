using System;

namespace Practice{
class Program{

    static void helloPrinter(string name = "Summit", int age = 27){
        Console.WriteLine(name + " is " + age);
    }

    static int squarePrinter(int x){
        return x * x;
    }

    static int multiplePrinter(int x, int y){
        return x * y;
    }


    // emum by example
        enum Level
        {
            Easy,
            Medium,
            Hard,
        }

    static void Main(string[] args){

        // Printing void function
        helloPrinter();
        helloPrinter("Sam");
        helloPrinter("Georgia", 56);

        // Printing parameter function
        Console.WriteLine(squarePrinter(3));
        Console.WriteLine(squarePrinter(81));

        // Printing multiplication table
        Console.Write("Number = ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 10; i++){
            Console.WriteLine(userInput + " X " + (i+1) + " = " + multiplePrinter(userInput, i+1));
        }

        // Printing Car detail from Car class
        Car carObj1 = new Car();
        Console.WriteLine(carObj1.make);  
        Console.WriteLine(carObj1.color);
        Console.WriteLine(carObj1.miles);
        carObj1.fullThorttle();

        // Modifying the carObj2 and printing
        Car carObj2 = new Car();
        carObj2.make = "Lexus";
        carObj2.color = "White";
        carObj2.miles = 94000;
        Console.WriteLine(carObj2.make);
        Console.WriteLine(carObj2.color);
        Console.WriteLine(carObj2.miles);
        carObj2.fullThorttle();


        // Implementing Plane class using constructor with parameter
        Plane planeObj1 = new Plane("Boeing", "747", "Wide Body");
        Plane planeObj2 = new Plane("Airbus", "321", "Narrow Body");
        Console.WriteLine(planeObj1.make + " " + planeObj1.model + " - " + planeObj1.bodyType);
        Console.WriteLine(planeObj2.make + " " + planeObj2.model + " - " + planeObj2.bodyType);

        // Using Motorbike through Encapsulation
        Motorbike bikeObj1 = new Motorbike("Honda", "CBR", 1232);
        Console.WriteLine(bikeObj1.Company + " - " + bikeObj1.Model + " - " + bikeObj1.Odometer + "km");

        // Inheritance use from parent and child
        Company companyObj = new Company();
        companyObj.Name = "Apple";
        companyObj.Tech = true;
        companyObj.Fortune500 = true;
        Console.WriteLine(companyObj.Name + " - is tech? " + companyObj.Tech + " - is Fortune 500? " + companyObj.Fortune500);
        Department departmentObj = new Department("Sales", "Summit Khatiwada", 55000);
        departmentObj.Name = "The Vedic Medic";
        departmentObj.Tech = false;
        departmentObj.Fortune500 = false;
        Console.WriteLine(departmentObj.Name + " " + departmentObj.Tech + " " + departmentObj.Fortune500);
        Console.WriteLine(departmentObj.DepartmentName + " " + departmentObj.DepartmentHead + " " + departmentObj.DepartmentBudget);

        // Polymorphism Calling
        //Animals animalObj = new Animals();
        //animalObj.animalSound();
        // Same animalSound will take other form now, giving different output
        Dog dogObj = new Dog();
        dogObj.animalSound();
        Cow cowObj = new Cow();
        cowObj.animalSound();

        // Interface Calling
        Course courseObj = new Course();
        courseObj.CourseOne();
        courseObj.CourseTwo();

        
        // enum Continuation

        Level levelObj = Level.Medium;
        switch(levelObj){
            case Level.Easy:
             Console.WriteLine("Easy Level");
             break;

            case Level.Medium:
            Console.WriteLine("Medium Level");
            break;

            case Level.Hard:
            Console.WriteLine("Hard Level");
            break;
        }


    }
}
}