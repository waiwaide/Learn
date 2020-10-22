using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DelegateAndEvent
{
    public  class SomeOne
    {
        public SomeOne(string name)
        {
            this.name = name;
        }
        public string name ;
        public void Buy(string things)
        {
            MessageBox.Show(string.Format("我帮你买{0}",things)); 
        }
    }
}
