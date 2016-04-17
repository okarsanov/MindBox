using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //маршрут линейный
            String[] route = { "Москва", "Кёльн", "Париж", "Лондон", "Мадрид", "Венеция" };//, "Прага", "Варшава", "Осло", "Стокгольм", "Хельсинки" };
            List<TravelCard> Route = GetTestRoute(GetCardSet(route));

            Console.WriteLine("Before:");
            for (int i = 0; i < Route.Count; i++)
            {
                Console.WriteLine(Route[i].ToString());
            }

            TravelCardsSorter sorter = new TravelCardsSorter();
            Route = sorter.Order(Route);
            

            Console.WriteLine("After:");
            for (int i = 0; i < Route.Count; i++)
            {
                Console.WriteLine(Route[i].ToString());
            }
            Console.ReadKey();
        }

        //составляет набор карточек из набора городов
        public static List<TravelCard> GetCardSet(String[] points)
        {
            List<TravelCard> result = new List<TravelCard>();
            for (Int32 i = 0; i < points.Length - 1; i++)
            {
                result.Add(new TravelCard(points[i], points[i+1]));
            }
            return result;
        }

        static Random stRand = new Random();

        //создаёт тестовый набор неупорядоченных карточек
        static public List<TravelCard> GetTestRoute(List<TravelCard> input)
        {
            List<TravelCard> result = new List<TravelCard>();
            Random rand = new Random(stRand.Next());
            while(input.Count > 0)
            {
                Int32 index = rand.Next(input.Count);
                TravelCard temp = input[index];
                input.RemoveAt(index);
                result.Add(temp);
            }
            return result;
        }
    }
}
