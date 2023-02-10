using System;

namespace AbstractClass_Demo
{
    interface Isample
    {
        //private int y = 900;
         void dd();
    }
    abstract class One
    {
    public void ff()
        {
            Console.WriteLine("FF from Abstract One");
        }
    }

    abstract class Sample:One
    {
        private int y = 900;
        public void aa()
        {
            Console.WriteLine(" AA from Abstract class");
            Console.WriteLine(" Y avlue in abstract class"+y);
        }

        public abstract void bb();


    }

    class Example : Sample
    {

        public override void bb()
        {
            Console.WriteLine(" BB from Abstarct class implementation given in Example class");
        }


        public void cc()
        {
            Console.WriteLine(" CC From Example Class");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        //   Example example=new Example();
        //    example.aa();
        //    example.bb();
        //    example.cc();
        //    example.ff();

            OverridingDemo overridingDemo=new OverridingDemo();
            overridingDemo.aa();
            overridingDemo.bb();
            overridingDemo.cc();
            
        }
    }
}
