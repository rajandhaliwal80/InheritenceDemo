using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo
{
    /// <summary>
    /// This is the person class
    /// 
    /// </summary>
    class Person
    {
        //private instance variable(feilds)
        private string _name;
        private int _age;

        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        // constructor
        /// <summary>
        /// 
        /// this is the constructor for the person class.it take two arguments.
        /// name which is string an age which is integer.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //public methods
        /// <summary>
        /// 
        /// this method allows the person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+" is talking");
        }
        
    }
}
