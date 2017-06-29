using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo
{
    class Student :Person
    {
        private string _student_id;

        private string Student_ID
        {
            get
            {
                return this._student_id;
            }
            set
            {
                this._student_id = value;
            }
        }
        //constructors---------------------------------------------------
        public Student(string name,int age,string studentID)
            :base(name,age)
        {
            this.Student_ID = studentID;
        }
        //public methods
        public void studies()
        {
            Console.WriteLine(this.Name+" is studying!");
            Console.WriteLine(this.Name+"\n is also agood student");
        }
    }
}
