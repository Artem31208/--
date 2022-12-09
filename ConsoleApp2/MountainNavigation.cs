using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class MountainNavigation
    {
        private static Random random = new Random();
        private static (int, int) shipPosition;
        private static int[,] map;

        static MountainNavigation()
        {
            shipPosition = new(5, 4);
            map = new int[,] {
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
        }

        public static void LetsStartNewJourney()
        {
            shipPosition = new(5, 4);
            map = new int[,] {
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain(), BuildTerrain() },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            Console.Clear();
            Console.WriteLine("Вітаю, капітане!");
            Console.WriteLine("Ми досліджуємо цю планету вже декілька років, але через її гористу місцевість це вкрай складно. Тим не менш ми вже поділили її на квадрати і перед вами");
            Console.WriteLine("");
            DrawTheMap();
            Console.WriteLine("");
            Console.WriteLine("Ваша задача, капітане, дослідити цю місцевість і прокласти безпечний маршрут через гори уникнувшли зіткнення");
        }

        private static int BuildTerrain() => random.Next(0, 4) == 0 ? 1 : 0;

        public static (int, int) GetShipPosition()
        {
            return shipPosition;
        }

        public static void DrawTheMap()
        {
            Console.WriteLine("PEREMOGA!!");

            for (var i = 0; i < 6; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    Console.Write(shipPosition.Item1 == i && shipPosition.Item2 == j ? "H" : map[i, j] == 0 ? "_" : "W");
                }
                Console.WriteLine();
            }
        }

        public static void MoveTheSpaceShip(int vertical = 0, int horizontal = 0)
        {
            if (vertical < -1 || vertical > 1 || horizontal < -1 || horizontal > 1)
                throw new ArgumentOutOfRangeException("Рух човна можливий лише на одне ділення за раз, від'ємний рух допустимий");

            shipPosition.Item1 += vertical;
            shipPosition.Item2 += horizontal;

            Console.WriteLine("Обробка маршруту, почекайте...");

            Thread.Sleep(3000);

            Console.WriteLine("Карта оновлена");

            DrawTheMap();
        }

    }
}
