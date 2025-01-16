using System.Collections;

namespace Tumakov
{
    public class Building
    {
        // Поля
        public int BuildingId { get; private set; }
        public string Address { get; private set; }
        public int Floors { get; private set; }

        // Закрытый конструктор
        private Building(int buildingId, string address, int floors)
        {
            BuildingId = buildingId;
            Address = address;
            Floors = floors;
        }

        // Метод для вывода информации о здании
        public void GetBuildingInfo()
        {
            Console.WriteLine($"ID здания: {BuildingId}");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Этажей: {Floors}");
        }

        // Фабричный класс
        public static class Creator
        {
            // Хеш-таблица для хранения объектов зданий
            private static readonly Hashtable buildings = new Hashtable();

            // Статический метод для создания здания с минимальными параметрами
            public static Building CreateBuild(int buildingId, string address)
            {
                return CreateBuild(buildingId, address, 1); // Здание по умолчанию с 1 этажом
            }

            // Перегруженный метод для создания здания с количеством этажей
            public static Building CreateBuild(int buildingId, string address, int floors)
            {
                if (buildings.ContainsKey(buildingId))
                {
                    Console.WriteLine($"Здание с ID {buildingId} уже существует.");
                    return null;
                }

                var building = new Building(buildingId, address, floors);
                buildings.Add(buildingId, building);
                Console.WriteLine($"Создано здание с ID {buildingId}.");
                return building;
            }

            // Метод для удаления здания
            public static void RemoveBuild(int buildingId)
            {
                if (buildings.ContainsKey(buildingId))
                {
                    buildings.Remove(buildingId);
                    Console.WriteLine($"Здание с ID {buildingId} удалено.");
                }
                else
                {
                    Console.WriteLine($"Здание с ID {buildingId} не найдено.");
                }
            }

            // Метод для получения здания
            public static Building GetBuild(int buildingId)
            {
                if (buildings.ContainsKey(buildingId))
                {
                    return (Building)buildings[buildingId];
                }

                Console.WriteLine($"Здание с ID {buildingId} не найдено.");
                return null;
            }
        }
    }
}
