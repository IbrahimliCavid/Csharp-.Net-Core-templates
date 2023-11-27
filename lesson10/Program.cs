using lesson10.Models;

namespace lesson10
{
    internal class Program
    {
        static void Main()
        {
            StudentAndTeacherTest();
        }
        static void StudentAndTeacherTest()
        {
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Name = "Cavid";
            schoolPerson.SurName = "Ibrahimli";
            schoolPerson.Age = 22;
            schoolPerson.Great();

            SchoolPerson student = new Student();
            student.Name = "Ibrahim";
            student.SurName = "Ibrahimli";
            student.Age = 27;
            student.GoToClasses();
            ((Student)student).ShowAge();


            SchoolPerson teacherSchool = new Teacher();
            Teacher teacher = (Teacher)teacherSchool;
            teacher.Name = "Ayaz";
            teacher.SurName = "Shahaliyev";
            teacher.Age = 31;
            teacher.Subject = "History";
            teacher.GoToClasses();
            teacher.Explain();



 
        }
    }
}