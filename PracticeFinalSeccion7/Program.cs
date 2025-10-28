namespace PracticeFinalSeccion7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastName, address, rfc;
            double balanceInitial, money;
            byte option;


            Console.Write("Insert your name: ");
            name = Console.ReadLine();

            Console.Write("Insert your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Insert your address: ");
            address = Console.ReadLine();

            Console.Write("Insert your RFC: ");
            rfc = Console.ReadLine();

            Console.Write("Insert your initial balance: ");
            balanceInitial = double.Parse(Console.ReadLine());

            BankAcount bankAcount = new BankAcount(name, lastName, balanceInitial, address, rfc);

            Console.WriteLine("Congratulation, his account has been created with succesful, press any key for continue");
            Console.ReadKey();

            do
            {

                Console.WriteLine("\n1. To deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check your balance");
                Console.WriteLine("4. Show information");
                Console.WriteLine("5. salir");

                Console.WriteLine("\n select a option");
                option = byte.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How much money you wish to deposit: ");
                        money = double.Parse(Console.ReadLine());
                        bankAcount.Deposit(money);
                        Console.WriteLine("deposit succesful");
                        break;
                    case 2:
                        Console.WriteLine("How much money you wish withdrawn");
                        money = double.Parse(Console.ReadLine());
                        bankAcount.Withdraw(money);                        
                        break;
                    case 3:
                        bankAcount.CheckYourBalance();
                        break;
                    case 4:
                        Console.WriteLine(bankAcount.ToString());
                        break;
                    case 5: Console.WriteLine("Thank you for use our system"); break;
                    default: Console.WriteLine("Option avaible: To deposite(1), withdraw(2), check balance(3), show information(4), exit(5)"); break;
                }
            } while (option >= 1 && option <= 4);
            Console.ReadKey();
        }

            
    }
    class BankAcount
    {
        private string name, lastName, address, rfc;
        private double balanceInitial;

        public BankAcount(string namePa, string lastNamePa, double balanceInitialPa, string addressPa, string rfcPa)
        {
            name = namePa;
            lastName = lastNamePa;
            address = addressPa;
            rfc = rfcPa;
            balanceInitial = balanceInitialPa;

            if (balanceInitial < 0)
            {
                throw new Exception("Initial balance cannot be negative");
            }


        }

        public double Deposit(double moneyPa)
        {   
            balanceInitial += moneyPa;
            return balanceInitial;
        }
        public double Withdraw(double moneyPa)
        {
            if (moneyPa >= balanceInitial)
            {
                Console.WriteLine("You don't have enough money for withdraw: ");

            }
            else
            {
                Console.WriteLine("Withdraw succesful");
                balanceInitial -= moneyPa;
            }
            return balanceInitial;
        }
        public void CheckYourBalance()
        {
            Console.WriteLine("You real balance is: " + balanceInitial);
        }
        public override string ToString()
        {
            string message;

            message = "Name: " + name + " " + lastName + "\naddres: " + address + "\nRFC " + rfc;
            return message;
        }
    }
}
