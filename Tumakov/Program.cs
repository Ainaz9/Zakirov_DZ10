
// Tumakov

using System.Collections;

namespace Tumakov
{
    class Program
    {
        static void Task11_1_YPR()
        {
            // Создаем фабрику счетов
            var factory = new BankAccountFactory();

            // Создаем два счета
            int account1 = factory.CreateAccount(500); // Счет с начальным балансом 500
            int account2 = factory.CreateAccount();    // Счет без начального баланса

            // Получаем информацию о счете
            var acc1 = factory.GetAccount(account1);
            acc1.Deposit(200);
            Console.WriteLine(acc1);

            // Закрываем один из счетов
            factory.CloseAccount(account2);
        }

        static void Task11_1_DZ()
        {
            Console.WriteLine("Работа с банковским счетом:");
            var bankAccount = new BankAccount_11_1_DZ(12345, 1000, AccountType_11_1_DZ.Savings);
            bankAccount.GetAccountInfo();
            bankAccount.UpdateBalance(1500);
            bankAccount.GetAccountInfo();

            Console.WriteLine();

            // Работа с объектами здания
            Console.WriteLine("Работа с объектами здания:");
            var building1 = Building.Creator.CreateBuild(1, "ул. Ленина, д. 10", 5);
            var building2 = Building.Creator.CreateBuild(2, "ул. Советская, д. 15");

            if (building1 != null)
                building1.GetBuildingInfo();

            if (building2 != null)
                building2.GetBuildingInfo();

            Console.WriteLine();

            // Удаление здания
            Building.Creator.RemoveBuild(1);

            // Попытка получить удаленное здание
            var removedBuilding = Building.Creator.GetBuild(1);
            if (removedBuilding == null)
            {
                Console.WriteLine("Здание с ID 1 не найдено.");
            }
        }
        static void Task12_1_YPR()
        {
            // Создаем два банковских счета
            var account1 = new BankAccount_12_YPR(101, 1000m, AccountType_12_YPR.Savings);
            var account2 = new BankAccount_12_YPR(101, 1000m, AccountType_12_YPR.Savings);
            var account3 = new BankAccount_12_YPR(102, 2000m, AccountType_12_YPR.Current);

            // Тестируем метод ToString
            Console.WriteLine("Информация о счетах:");
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            Console.WriteLine();

            // Тестируем операторы == и !=
            Console.WriteLine("Сравнение счетов:");
            Console.WriteLine($"account1 == account2: {account1 == account2}");
            Console.WriteLine($"account1 != account3: {account1 != account3}");

            Console.WriteLine();

            // Тестируем метод Equals
            Console.WriteLine("Тест метода Equals:");
            Console.WriteLine($"account1.Equals(account2): {account1.Equals(account2)}");
            Console.WriteLine($"account1.Equals(account3): {account1.Equals(account3)}");

            Console.WriteLine();

            // Тестируем работу метода GetHashCode
            Console.WriteLine("Хэш-коды счетов:");
            Console.WriteLine($"HashCode account1: {account1.GetHashCode()}");
            Console.WriteLine($"HashCode account2: {account2.GetHashCode()}");
            Console.WriteLine($"HashCode account3: {account3.GetHashCode()}");
        }
        static void Task12_2_YPR()
        {
            Rational r1 = new Rational(3, 4);
            Rational r2 = new Rational(2, 5);

            Console.WriteLine($"r1: {r1}");
            Console.WriteLine($"r2: {r2}");
            Console.WriteLine($"r1 + r2: {r1 + r2}");
            Console.WriteLine($"r1 - r2: {r1 - r2}");
            Console.WriteLine($"r1 * r2: {r1 * r2}");
            Console.WriteLine($"r1 / r2: {r1 / r2}");
            Console.WriteLine($"r1 == r2: {r1 == r2}");
            Console.WriteLine($"r1 != r2: {r1 != r2}");
            Console.WriteLine($"r1 > r2: {r1 > r2}");
            Console.WriteLine($"r1 < r2: {r1 < r2}");
            Console.WriteLine($"(int)r1: {(int)r1}");
            Console.WriteLine($"(float)r1: {(float)r1}");
        }
        static void Task12_1_DZ()
        {
            // Пример работы с комплексными числами
            Complex c1 = new Complex(2, 3); // 2 + 3i
            Complex c2 = new Complex(1, -4); // 1 - 4i

            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");

            // Сложение
            Complex sum = c1 + c2;
            Console.WriteLine($"c1 + c2 = {sum}");

            // Вычитание
            Complex difference = c1 - c2;
            Console.WriteLine($"c1 - c2 = {difference}");

            // Умножение
            Complex product = c1 * c2;
            Console.WriteLine($"c1 * c2 = {product}");

            // Проверка на равенство
            Complex c3 = new Complex(2, 3); // 2 + 3i
            Console.WriteLine($"c1 == c3: {c1 == c3}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("11.1 Упражнение");
            Task11_1_YPR();
            Console.WriteLine();
            Console.WriteLine("11.1 Домашнее задание");
            Task11_1_DZ();
            Console.WriteLine();
            Console.WriteLine("12.1 Упражнение");
            Task12_1_YPR();
            Console.WriteLine();
            Console.WriteLine("12.2 Упражнение");
            Task12_2_YPR();
            Console.WriteLine();
            Console.WriteLine("12.1 Домашнее задание");
            Task12_1_DZ();
            Console.WriteLine();
        }
    }
}
