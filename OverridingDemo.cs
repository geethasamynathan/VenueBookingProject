using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Demo
{
    class Parent
    {
        public virtual void aa()
        {
            Console.WriteLine(" aa from from Parent Class");
        }
        public void bb()
        {

            Console.WriteLine("bbb from Parent");
        }
    }

    internal class OverridingDemo:Parent

    {
        public override void aa()
        {
            base.aa();
            Console.WriteLine(" aa Overriden in Child class ");
        }

        public void cc()
        {
            Console.WriteLine("cc from Child");
        }
    }
}
