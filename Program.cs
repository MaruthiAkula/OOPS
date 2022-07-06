using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Student
    {
        public string firstname;
        public string lastname;
        public int age;
        public string contact;
        public void printalldetails()
        {
            Console.WriteLine(firstname + " " + lastname);//concatenate
            Console.WriteLine("Full Name is {0},{1}", firstname, " ", lastname);//place holder
            Console.WriteLine("AGE  " + age);
            Console.WriteLine("NUmber{0}",contact);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.firstname = "MARUTHI";
            obj.lastname = "AKULA";
            obj.age = 10;
            obj.contact = " 1234567890";
            obj.printalldetails();
        }
    }
}
