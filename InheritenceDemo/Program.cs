using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo
{
    class Program //driverclass
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rajandeep", 18);
            person.Talks();
            Student student = new Student("bobo", 20,"123456789");
            student.Talks();
            student.studies();
        }
    }
}
