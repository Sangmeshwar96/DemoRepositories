namespace Inheritance
{
    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("This is a method of base class....");
        }

    }
    class DerivedClass : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("This is a method of derived class....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc1 = new DerivedClass();
            dc1.Show1();
            dc1.Show2();
            Console.ReadLine();
        }
    }
}