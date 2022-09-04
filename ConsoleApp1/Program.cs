// See https://aka.ms/new-console-template for more information
using Zoo;
using System;

Console.WriteLine("Hello, World!");

// 字符串 string " "
// 字节 char ''
// 整型 int 10
// 浮点数 double 10.0
//布尔值 bool true false

string name = "Sky";
string cent = "helloWorld is sky";
char sex = 'M';
int age = 24;
double height = 184.9;
bool is_male = true;

Console.WriteLine("名字：" + name);
Console.WriteLine("性别：" + sex);
Console.WriteLine("年龄：" + age);
Console.WriteLine("高度：" + height);
Console.WriteLine("是否是男性：" + is_male);
Console.WriteLine("------------------------------");
// 字符串换行
Console.WriteLine("名字：" + "\n" + name);
Console.WriteLine("\"hello! {0}\"" + "\n" ,name);
Console.WriteLine(name.Length);
Console.WriteLine("------------------------------");
// 字符串内全部大写的方法.ToUpper()
Console.WriteLine(name.ToUpper());
// 字符串内全部小写的方法.ToLower()
Console.WriteLine(name.ToLower());
// 检测字符串内是否有子字串的方法.Contains(带入需要检测的字符串)
Console.WriteLine(name.Contains("k"));
// 返回字符串内哪个位置的值
Console.WriteLine(name[1]);
// 返回字符串内哪个值的位置
Console.WriteLine(name.IndexOf("ky"));
// 返回字符串内哪个值的位置（找不到返回-1
Console.WriteLine(name.IndexOf("Sy"));
// 字符串切割（第二个参数取几位
Console.WriteLine(cent.Substring(1,5));
Console.WriteLine("------------------------------");
// 数字
// 浮点数（其中一个是浮点，结果就是浮点
Console.WriteLine(5 / 2.0);
// 综合运算
int num = 10;
Console.WriteLine(num * 2.0 /2.1);
// 绝对值
Console.WriteLine(Math.Abs(-100));
// 次方
Console.WriteLine(Math.Pow(2,3));
// 开根号
Console.WriteLine(Math.Sqrt(36));
// 取大值
Console.WriteLine(Math.Max(10, 36));
// 取小值
Console.WriteLine(Math.Min(10,36));
// 四舍五入
Console.WriteLine(Math.Round(10.6));
Console.WriteLine("------------------------------");
// 用户输入 （只用write不换行
//Console.Write("请输入名字：");
//string str = Console.ReadLine();
//Console.WriteLine("名字：{0}",str);
Console.WriteLine("------------------------------");
// 简易计算器 （ReadLine输入是string类型，要显式转换
/*Console.WriteLine("请输入第一个数：");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入第一个数：");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("求和：{0}", num1 + num2);*/
Console.WriteLine("------------------------------");
// 数组（已知值
int[] scores = { 50, 60, 70, 99, 100 };
Console.WriteLine(scores[0]);
scores[2] = 88;
Console.WriteLine(scores[2]);
//数组（未知值,[]里面有几个，就可以放几个值
string[] phone = new string[5];
phone[0] = "sss";
Console.WriteLine(phone[0]);
Console.WriteLine("------------------------------");
// if语句
bool hungry = false;
if (hungry)
{
    Console.WriteLine("饿了就吃");
}
else
{
    Console.WriteLine("爬");
}
Console.WriteLine("------------------------------");
// 进阶计算器
/* Console.WriteLine("请输入第一个数：");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入要进行的运算：");
string oper = Console.ReadLine();
Console.WriteLine("请输入第一个数：");
double num2 = Convert.ToDouble(Console.ReadLine());
if (oper == "+")
{
    Console.Write("输出结果：{0}", num1 + num2);
}
else if (oper == "-")
{
    Console.Write("输出结果：{0}", num1 - num2);
}
else if (oper == "*")
{
    Console.Write("输出结果：{0}", num1 * num2);
}
else if (oper == "/")
{
    Console.Write("输出结果：{0}", num1 / num2);
}
else
{
    Console.Write("不合法");
}*/
Console.WriteLine("------------------------------");
// while循环
int num1 = 1;
while (num1 <= 10)
{
    Console.WriteLine(num1);
    num1++;
}
// do while循环（先执行do里的内容，再执行判断while
int num2 = 6;
do
{
    Console.WriteLine(num2);
    num2++;
}while (num2 <= 5);
Console.WriteLine("------------------------------");
// 猜数字游戏（猜中数字 限制猜测次数（do while版本
/* int num3;
Random rand = new Random();
num3 = rand.Next(1, 200);
int guess;
int guess_count = 0;
int guess_limit = 10;
bool win = false;
do
{
    Console.WriteLine("请输入猜的数字：");
    guess = Convert.ToInt32(Console.ReadLine());
    guess_count++;

    if (guess < num3)
    {
        Console.WriteLine("猜小了");
    }
    else if (guess > num3)
    {
        Console.WriteLine("猜大了");
    }
    else
    {
        Console.WriteLine("对了");
        win = true;
    }
} while (guess != num3 && guess_count < guess_limit);

if (!win)
{
    Console.WriteLine("输了");
} */
Console.WriteLine("------------------------------");
// 猜数字游戏（猜中数字 限制猜测次数（while版本
/* int num3_2;
Random rand_2 = new Random();
num3_2 = rand_2.Next(1,200);
int CountNum = 0;
int guess_2;
Console.WriteLine("请输入猜的数字：");
guess_2 = Convert.ToInt32(Console.ReadLine());
while (guess_2 != num3_2 && CountNum < 10) 
{
    if(guess_2 < num3_2)
    {
        Console.WriteLine("输入的数字小了");
        guess_2 = Convert.ToInt32(Console.ReadLine());
        CountNum++;
    }
    else
    {
        Console.WriteLine("输入的数字大了");
        guess_2 = Convert.ToInt32(Console.ReadLine());
        CountNum++;
    }
}
if(CountNum >= 10)
{
    Console.WriteLine("失败");
}
else
{
    Console.WriteLine("胜利");
} */
Console.WriteLine("------------------------------");
//for循环
int[] nums = { 10, 20, 30, 40, 50, 60 };
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(nums[i]);
}
Console.WriteLine("------------------------------");
//二维数组
// row 横
// column 竖
int[,] nums2 = {  
    { 1, 2, 3 }, 
    { 4, 5, 6 }, 
    { 7, 8, 9 } 
};
Console.WriteLine(nums2[1, 2]);
// 新建二维数组
int[,] nums3 = new int[3,5];
nums3[0,0] = 1;
Console.WriteLine(nums3[0, 0]);
Console.WriteLine("------------------------------");
// class、object
// 创建对象person1
Person person1 = new Person();
person1.height = 185.5;
person1.name = "sky";
person1.age = 24;
System.Console.WriteLine(person1.name);
System.Console.WriteLine(person1.height);
System.Console.WriteLine(person1.age);
// 创建对象person2
Person person2 = new Person();
person2.height = 170.0;
person2.name = "fsy";
person2.age = 24;
System.Console.WriteLine(person2.name);
System.Console.WriteLine(person2.height);
System.Console.WriteLine(person2.age);
Console.WriteLine("------------------------------");
// namespace （存放class的空间） using 
Zoo.Animal tiger = new Animal();
tiger.height = 3;
tiger.weight = 2;
tiger.type = "猫科";
Console.WriteLine(tiger.height);
Console.WriteLine(tiger.weight);
Console.WriteLine(tiger.type);
