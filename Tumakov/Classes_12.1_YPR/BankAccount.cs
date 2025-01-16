
namespace Tumakov
{
    public enum AccountType_12_YPR
    {
        Savings,   // Сберегательный
        Current    // Текущий
    }

    public class BankAccount_12_YPR
    {
        // Поля класса
        private int accountNumber;
        private decimal balance;
        private AccountType_12_YPR accountType;

        // Конструктор
        public BankAccount_12_YPR(int accountNumber, decimal initialBalance, AccountType_12_YPR accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.accountType = accountType;
        }

        // Переопределение оператора ==
        public static bool operator ==(BankAccount_12_YPR account1, BankAccount_12_YPR account2)
        {
            if (ReferenceEquals(account1, account2)) return true;
            if (account1 is null || account2 is null) return false;

            return account1.accountNumber == account2.accountNumber &&
                   account1.balance == account2.balance &&
                   account1.accountType == account2.accountType;
        }

        // Переопределение оператора !=
        public static bool operator != (BankAccount_12_YPR account1, BankAccount_12_YPR account2)
        {
            return !(account1 == account2);
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (obj is BankAccount_12_YPR otherAccount)
            {
                return this == otherAccount;
            }
            return false;
        }

        // Переопределение метода GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(accountNumber, balance, accountType);
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Счет #{accountNumber}, Баланс: {balance:C}, Тип: {accountType}";
        }
    }
}
