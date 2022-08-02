// Implementation of Abastraction via Interface

namespace Practice{
    
    interface IOnlineCourse{
        void CourseOne();
    }

    interface IClassCourse{
        void CourseTwo();
    }

    public class Course : IOnlineCourse, IClassCourse{
        public void CourseOne(){
            Console.WriteLine("This is an online class");
        }

        public void CourseTwo(){
            Console.WriteLine("This is a class course");
        }
    }
}