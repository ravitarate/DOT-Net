namespace BankingCRUDOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;

            do
            {
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Deposite Amount");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Your Choice");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Thank You");
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

            } while (ch != 5);
        }
    }

    public class Bank
    {
        int Acno;
        string Name;
        double Bal;

        public Bank(int acno, string name, double bal)
        {
            Acno = acno;
            Name = name;
            Bal = bal;
        }
    }

    public class Saving : Bank
    {
        double InterestRate;
        public Saving(int acno, string name, double bal, double ir):base(acno, name, bal) 
        {
            InterestRate = ir;
        }

        public void ApplyInterest()
        {
            double interest = Bal * InterestRate / 100;
            Bal += interest;
            Console.WriteLine($"Interest Applied: {interest}, New Balance: {Balance}");
        }
    }


    public class Current : Bank
    {
        double OverdraftLimit;

        public Current(int acno, string name, double bal, double ol) : base(acno, name, bal)
        {
            OverdraftLimit = ol;
        }
    }
        


}
