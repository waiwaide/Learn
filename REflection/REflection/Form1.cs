using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace REflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\DELL\source\repos\REflection\student\bin\Debug\student.dll");

            Console.WriteLine("程序集名字："+assembly.FullName);
            Console.WriteLine("程序集位置：" + assembly.Location);
            Console.WriteLine("运行程序集需要的CLR版本：" + assembly.ImageRuntimeVersion);
            Console.WriteLine("===================================");
            //获取模块信息
            Module[] modules = assembly.GetModules();
            foreach (Module item in modules)
            {
                Console.WriteLine("模块名称："+item.Name);
                Console.WriteLine("模块版本ID"+item.ModuleVersionId);
            }
            Console.WriteLine("===================================");
            //获取类，通过模块和程序集都可以
            Type[] types = assembly.GetTypes();
            foreach (Type item in types)
            {
                Console.WriteLine("类型名称：" + item.Name);
                Console.WriteLine("类型的完全命名：" + item.FullName);
                Console.WriteLine("类型的类别：" + item.Attributes);
                Console.WriteLine("类型的GUID：" + item.GUID);
                Console.WriteLine("===================================");
            }
            //获取主要类的成员信息
            Type studentType = assembly.GetType("student.student");
            MemberInfo[] mi = studentType.GetMembers();
            foreach (MemberInfo item in mi)
            {
                Console.WriteLine("成员名称：" + item.Name);
                Console.WriteLine("成员类别：" + item.MemberType);
            }
            Console.WriteLine("===================================");

            //获取方法

            BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance;
            MemberInfo[] memberInfos = studentType.GetMethods(flags);
            foreach (MethodInfo item in memberInfos)
            {
                Console.WriteLine("public类型的，不包括基类继承的实例方法:" + item.Name);
            }
            Console.WriteLine("========================================");
            BindingFlags flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;
            MethodInfo[] methods = studentType.GetMethods(flag);
            foreach (MethodInfo item in methods)
            {
                Console.WriteLine("非public类型的，不包括基类继承的实例方法:" + item.Name);
            }
            Console.WriteLine("========================================");


            //获取属性
            //获取属性
            BindingFlags flags2 = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance;
            PropertyInfo[] pi = studentType.GetProperties(flags2);
            foreach (PropertyInfo item in pi)
            {
                Console.WriteLine("属性名称：" + item.Name);
            }
        }
    }
}
