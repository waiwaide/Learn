using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime;


namespace DesignPatterns.Singleton
{
    // 使用单例和语言无关。
    //意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
    //主要解决：一个全局使用的类频繁地创建与销毁。
    //何时使用：当您想控制实例数目，节省系统资源的时候。
    //使用场景： 
    //1. 要求生产唯一序列号；
    //2. WEB 中的计数器，不用每次刷新都在数据库里加一次，用单例先缓存起来；
    //3. 创建的一个对象需要消耗的资源过多，比如 I/O 与数据库的连接等；
    //4. 全局配置文件访问类，单例来保证唯一性；
    //5. 日志记录帮助类，全局一个实例一般就够了；
    //6. 桌面应用常常要求只能打开一个程序实例或一个窗口。
    class SingletonLM
    {
        //懒汉式,线程不安全
        private SingletonLM() { }
        private static SingletonLM singleton = null;
        //静态工厂方法
        public static SingletonLM Singleton
        {
            get { return singleton ?? (singleton = new SingletonLM()); }

        }
    }

    class SingletonHM
    {
        //饿汉式,线程安全
        private SingletonHM() { }
        private static SingletonHM singleton = new SingletonHM();
        public static SingletonHM GetSingleton()
        {
            return singleton;
        }

    }

    class SingletonSync
    {
        //加锁，线程安全，但影响性能
        private SingletonSync() { }
        private static SingletonSync singleton = null;
        private static readonly object SynObject = new object();
        public static SingletonSync Singleton
        {
            get
            {
                lock (SynObject)
                {
                    return singleton ?? (singleton = new SingletonSync());
                }
            }
        }

    }

    class SingletonDoubleChecked
    {
        //双重检验，线程安全，
        private SingletonDoubleChecked() { }
        private static SingletonDoubleChecked singleton = null;
        private static readonly object SynObject = new object();
        public static SingletonDoubleChecked Singleton
        {
            get
            {
                if (null == singleton)
                {
                    lock (SynObject)
                    {
                        singleton = new SingletonDoubleChecked();
                    }
                }
                return singleton;
            }
        }

    }

    class SingletonS
    {
        //不太懒惰，安全，影响性能

        private static readonly SingletonS singleton = new SingletonS();

        //显式静态构造函数告诉C#编译器
        //不要将类型标记为BeforeFieldInit
        static SingletonS()
        {

        }
        private SingletonS()
        {

        }
        public static SingletonS Singleton
        {

            get
            {
                return singleton;
            }
        }
    }

    class SingletonSS
    {
        //完全懒惰的，安全
        private SingletonSS()
        {
        }

        //实例化是由对嵌套类的静态成员的第一次引用触发的
        public static SingletonSS Singleton { get { return Nested.singleton; } }

        private class Nested
        {
           //显式静态构造函数告诉C#编译器
           //不要将类型标记为BeforeFieldInit
            static Nested()
            {
            }
            internal static readonly SingletonSS singleton = new SingletonSS();
        }
    }

    class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(()=>new SingletonLazy());

        public static SingletonLazy Singleton { get { return lazy.Value; } }

        private SingletonLazy()
        {

        }
    }
}
