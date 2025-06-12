namespace _02Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass d = new DerivedClass(265);
            // d.show();
            BaseClass B = new DerivedClass(1212);
            B.show();
        }
    }

    public class BaseClass
    {
        int n;
        public BaseClass( int x)
        {
            n = x;
            Console.WriteLine("in base class constructor");
        }

        public void show()
        {

            Console.WriteLine(n);
        }
    }

    public class DerivedClass: BaseClass
    {
        public DerivedClass(int m) : base(m)
        {
            Console.WriteLine("in derived class constructor");
        }
        public new void show()
        {
            Console.WriteLine("hello");
        }

    }
}
