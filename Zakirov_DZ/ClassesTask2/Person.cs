
namespace DZ
{
    public class Person
    {
        public string Name { get; }
        public string Hobby { get; }

        // Конструктор
        public Person(string name, string hobby)
        {
            Name = name;
            Hobby = hobby;
        }

        // Реакция человека на событие
        public string ReactToEvent(string eventName)
        {
            return $"Ого! {Name} в восторге от события \"{eventName}\"!";
        }
    }
}
