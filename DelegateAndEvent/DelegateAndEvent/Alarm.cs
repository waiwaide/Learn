using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DelegateAndEvent
{
    public class Alarm
    {
        public void MakeAlert(Object sender, BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;     //这里是不是很熟悉呢？
                                                //访问 sender 中的公共字段
            MessageBox.Show(String.Format("Display：{0} - {1}:/r/n Display：水快烧开了，当前温度：{2}度。 ", heater.area, heater.type, e.temperature));
        }
    }
}
