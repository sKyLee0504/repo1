using System;    
internal class Person
    {
        public double height;
        public int age;
        public string name;
        
        public void SayHi()
    {
        Console.WriteLine("你好，我叫{0}", name);
    }
        public string IsAdult()
    {
        if (age >= 18)
        {
            return "成年";
        } else
        {
            return "未成年";
        }
    }
    }
