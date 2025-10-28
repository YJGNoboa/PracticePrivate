//Program.cs
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
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out balanceInitial))
                {
                    break;
                }
                Console.WriteLine("Error, this field only admit numbers");

            }
            Client client1 = new Client(name, lastName, address, rfc);
            BankAccount bankAcount1 = new BankAccount(balanceInitial);

            Console.WriteLine("Congratulation, your account has been created with succesful, press any key for continue");
            Console.ReadKey();

            do
            {

                Console.WriteLine("\n1. To deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check your balance");
                Console.WriteLine("4. Show information");
                Console.WriteLine("5. salir");
                Console.WriteLine("=====================");
                Console.WriteLine("\n select a option");
                while (true)
                {
                    if (byte.TryParse(Console.ReadLine(), out option))
                    {
                        break;
                    }
                    Console.WriteLine("This fiel only admit number between 1 to 5");
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How much money you wish to deposit: ");
                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out money) && money > 0)
                            {
                                bankAcount1.Deposit(money);
                                Console.WriteLine("Press enter for continue");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Error, this field only admit numbers postive");

                        }
                        Console.WriteLine("deposit succesful");
                        break;
                    case 2:
                        Console.WriteLine("How much money you wish withdrawn");
                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out money) && money > 0)
                            {
                                bankAcount1.Withdraw(money);
                                Console.WriteLine("Press enter for continue");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Error, this field only admit numbers positive");
                        }
                        Console.WriteLine("Withdrawal successful.");
                        break;
                    case 3:
                        bankAcount1.CheckYourBalance();
                        Console.WriteLine("Press enter for continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(client1.ToString());
                        Console.WriteLine("Press enter for continue");
                        Console.ReadKey();
                        break;
                    case 5: Console.WriteLine("Thank you for use our system"); break;
                    default: Console.WriteLine("Available options: To deposite(1), withdraw(2), check balance(3), show information(4), exit(5)"); break;
                }
            } while (option >= 1 && option <= 4);
            Console.ReadKey();
        }
    }
    
}
