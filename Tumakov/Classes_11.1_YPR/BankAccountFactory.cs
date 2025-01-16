
using System.Collections;

namespace Tumakov
{
    public class BankAccountFactory
    {
        private readonly Hashtable _accounts = new Hashtable();
        private int _nextAccountNumber = 1;

        // Метод создания счета с балансом по умолчанию
        public int CreateAccount()
        {
            return CreateAccount(0);
        }

        // Перегруженный метод создания счета с указанным балансом
        public int CreateAccount(decimal initialBalance)
        {
            int accountNumber = _nextAccountNumber++;
            var account = new BankAccount(accountNumber, initialBalance);
            _accounts.Add(accountNumber, account);
            return accountNumber;
        }

        // Метод закрытия счета
        public bool CloseAccount(int accountNumber)
        {
            if (_accounts.ContainsKey(accountNumber))
            {
                _accounts.Remove(accountNumber);
                return true;
            }

            return false;
        }

        // Метод для получения объекта счета по номеру
        public BankAccount GetAccount(int accountNumber)
        {
            return _accounts.ContainsKey(accountNumber) ? (BankAccount)_accounts[accountNumber] : null;
        }
    }
}
