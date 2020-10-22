using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace HowToUseBase
{
    public class A
    {
        public A()
        {
            MessageBox.Show("A");
        }
    }
    public class B:A
    {
        public B():base()
        {
            MessageBox.Show("B");
        }
    }
    public class C
    {
        public virtual void MethodC()
        {
            MessageBox.Show("MethodC");
        }
    }

    public class D:C
    {
        public override void MethodC()
        {
            base.MethodC();
        }
    }
}
