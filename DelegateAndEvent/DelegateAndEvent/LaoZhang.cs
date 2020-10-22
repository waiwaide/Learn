using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegateAndEvent
{
    public delegate void BuyDelegate(string things);
    public class LaoZhang
    {
        public void ShoutSomeOneBuySomeThingsForMe(string name, string things, BuyDelegate buyDelegate)
        {
            MessageBox.Show(string.Format("{0},给我买{1}",name,things));
            buyDelegate(things);
        }
    }
}
