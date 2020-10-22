using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateAndEvent
{
    public class Heater
    {
      
            private int temperature;
            public string type = "RealFire 001";       // 添加型号作为演示
            public string area = "China Xian";         // 添加产地作为演示
                                                       //声明委托
          
            public event BoiledEventHandler Boiled; //声明事件
            public event Action<object, BoiledEventArgs> BoiledAction;
            
         

            // 可以供继承自 Heater 的类重写，以便继承类拒绝其他对象对它的监视
            protected virtual void OnBoiled(BoiledEventArgs e)
            {
                if (Boiled != null)
                { // 如果有对象注册
                    Boiled(this, e);  // 调用所有注册对象的方法
                }
            }

        protected virtual void OnBoiledAction(BoiledEventArgs e)
        {
            if (BoiledAction != null)
            { // 如果有对象注册
                BoiledAction(this, e);  // 调用所有注册对象的方法
            }
        }

        // 烧水。
        public void BoilWater()
            {
                for (int i = 0; i <= 100; i++)
                {
                    temperature = i;
                    if (temperature > 95)
                    {
                        //建立BoiledEventArgs 对象。
                        BoiledEventArgs e = new BoiledEventArgs(temperature);
                   
                        OnBoiled(new BoiledEventArgs(temperature));  // 调用 OnBolied方法
                    }
                }
            }
        public void BoilWaterAction()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    //建立BoiledEventArgs 对象。
                    //BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiledAction(new BoiledEventArgs(temperature));  // 调用 OnBolied方法
                }
            }
        }

    }
}
