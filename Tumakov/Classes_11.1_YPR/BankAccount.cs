
namespace Tumakov
{
    public class BankAccount
    {
        // Свойства счета
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        // Конструктор с модификатором доступа internal
        internal BankAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Метод пополнения счета
        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма должна быть больше нуля");
            Balance += amount;
        }

        // Метод снятия средств
        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма должна быть больше нуля");
            if (amount > Balance) throw new InvalidOperationException("Недостаточно средств");
            Balance -= amount;
        }
    }
}
