using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    // student有的方法和属性、parent上就有 : Parent继承 重复的部分在student类内可以删除
    internal class Student : Parent
    {
        public string school;

        public Student(string name, int age, string school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }
        public void printSchool()
        {
            Console.WriteLine(school);
        }

    }
}
