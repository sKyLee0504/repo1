// See https://aka.ms/new-console-template for more information
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

// 字符串换行
Console.WriteLine("名字：" + "\n" + name);
Console.WriteLine("\"hello! {0}\"" + "\n" ,name);
Console.WriteLine(name.Length);

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

// 用户输入 （只用write不换行
Console.Write("请输入名字：");
string str = Console.ReadLine();
Console.WriteLine("名字：{0}",str);

// 简易计算器 （ReadLine输入是string类型，要显式转换
Console.WriteLine("请输入第一个数：");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入第一个数：");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("求和：{0}", num1 + num2);
