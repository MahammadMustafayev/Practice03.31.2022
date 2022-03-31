using System;
using Practice_03._31._2022_.Models;
namespace Practice_03._31._2022_
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("qwerty123@gmail.com","7ukDM78");
            //Console.WriteLine("------------Menu----------");
            Console.WriteLine(user.Passwordchecker("74tgukDM788"));


            
        }
    }
}
