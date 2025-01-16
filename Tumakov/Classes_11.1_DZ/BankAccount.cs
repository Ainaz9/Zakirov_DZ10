
namespace Tumakov
{
    public enum AccountType_11_1_DZ
    {
        Savings,   // Сберегательный
        Current    // Текущий
    }

    public class BankAccount_11_1_DZ
    {
        // Поля класса
        private int accountNumber;
        private decimal balance;
        private AccountType_11_1_DZ accountType;

        // Конструктор
        public BankAccount_11_1_DZ(int accountNumber, decimal initialBalance, AccountType_11_1_DZ accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.accountType = accountType;
        }

        // Метод для получения данных счета
        public void GetAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance:C}");
            Console.WriteLine($"Тип счета: {accountType}");
        }

        // Метод для изменения баланса
        public void UpdateBalance(decimal newBalance)
        {
            if (newBalance < 0)
            {
                Console.WriteLine("Баланс не может быть отрицательным.");
                return;
            }
            balance = newBalance;
        }
    }
}
