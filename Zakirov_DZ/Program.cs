
// DZ

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список людей с их увлечениями
            var people = new List<Person>
            {
                new Person("Алиса", "выход нового сериала"),
                new Person("Борис", "концерт любимой группы"),
                new Person("Сергей", "выставка современного искусства")
            };

            // Заранее определенный список событий
            var events = new List<string>
            {
                "выход нового сериала",
                "концерт любимой группы",
                "выставка современного искусства",
                "чемпионат по шахматам"
            };

            Console.WriteLine("Доступные события:");
            for (int i = 0; i < events.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {events[i]}");
            }

            Console.Write("\nВведите номер интересующего события: ");
            if (int.TryParse(Console.ReadLine(), out int eventIndex) && eventIndex > 0 && eventIndex <= events.Count)
            {
                string selectedEvent = events[eventIndex - 1];
                Console.WriteLine($"\nВы выбрали событие: \"{selectedEvent}\"\n");

                // Проверяем, кого из людей интересует выбранное событие
                bool found = false;
                foreach (var person in people)
                {
                    if (person.Hobby == selectedEvent)
                    {
                        Console.WriteLine(person.ReactToEvent(selectedEvent));
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("К сожалению, никого не интересует это событие.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }
}
