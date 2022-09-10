using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    // 静态类不可以创建实例
    static class Tool
    {
        // 该方法属于类Tool本身
        public static void SayHi()
        {
            Console.WriteLine("hello");
        }
    }
}
