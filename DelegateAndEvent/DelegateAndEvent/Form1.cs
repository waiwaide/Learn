using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegateAndEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //委托类型的名称都应该以EventHandler结束。
        //委托的原型定义：有一个void返回值，并接受两个输入参数：一个Object 类型，一个 EventArgs类型(或继承自EventArgs)。
        //事件的命名为 委托去掉 EventHandler之后剩余的部分。
        //继承自EventArgs的类型应该以EventArgs结尾。

        private void button1_Click(object sender, EventArgs e)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();

            heater.Boiled += alarm.MakeAlert;   //注册方法
            heater.Boiled += (new Alarm()).MakeAlert;      //给匿名对象注册方法
            heater.Boiled += new BoiledEventHandler(alarm.MakeAlert);    //也可以这么注册
            heater.Boiled += Display.ShowMsg;       //注册静态方法

            heater.BoilWater();   //烧水，会自动调用注册过对象的方法
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.BoiledAction += alarm.MakeAlert;
            heater.BoilWaterAction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaoZhang laoZhang = new LaoZhang();
            SomeOne someOne = new SomeOne("小王");
            BuyDelegate buyDelegate;
            buyDelegate = someOne.Buy;
            laoZhang.ShoutSomeOneBuySomeThingsForMe(someOne.name,"香蕉", buyDelegate);
            
        }
    }

    public class Display
    {
        public static void ShowMsg(Object sender, BoiledEventArgs e)
        {   //静态方法
            Heater heater = (Heater)sender;
            MessageBox.Show(String.Format("Display：{0} - {1}:/r/n Display：水快烧开了，当前温度：{2}度。 ", heater.area, heater.type, e.temperature));
        
        }
    }
}
