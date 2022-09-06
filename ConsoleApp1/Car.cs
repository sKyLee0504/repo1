using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry
{
    internal class Car
    {
        public string name;
        public string brand;
        public int age;
        public bool isNew;

        public Car(string name, string brand, int age, bool isNew)
        {
            // this表示左边的name为属性名。右边的name为传入的参数
            this.name = name;
            this.brand = brand;
            this.age = age;
            this.isNew = isNew;
            Console.WriteLine(name);
            Console.WriteLine(brand);
            Console.WriteLine(age);
            Console.WriteLine(isNew);
        }
    }
}
