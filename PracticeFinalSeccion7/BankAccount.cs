//Class BankAccount
namespace PracticeFinalSeccion7
{
    class BankAccount
    {
        
        private double balanceInitial;

        public BankAccount(double balanceInitialPa)
        {
            
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
            balanceInitial -= moneyPa;            
            return balanceInitial;
        }
        public void CheckYourBalance()
        {
            Console.WriteLine("You real balance is: " + balanceInitial);
        }
        
    }
}
