namespace _03MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo1();
            d.add();
        }
    }

    public class Demo
    {

        public virtual void add()
        {
            Console.WriteLine("add two number");
        }
    }

    public class Demo1:Demo
    {

       
        public override void add()
        {
            Console.WriteLine("add 3 no.");
        }
    }
}
