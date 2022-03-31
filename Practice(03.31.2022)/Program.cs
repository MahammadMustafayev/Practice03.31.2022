using System;
using Practice_03._31._2022_.Models;
namespace Practice_03._31._2022_
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("qwerty123@gmail.com", "74tgukDM788");
            //Console.WriteLine("------------Menu----------");
            Student student = new Student("ASd", 100);
            Group group = new Group("AP205", 12);
            //Console.WriteLine(group.CheckGroupNo("AP205"));
            group.GetAllStudents(student);

        }
    }
}
