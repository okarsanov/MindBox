using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxConsole;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class MindBoxTest
    {
        private static Random stRand = new Random();

        [TestMethod]
        public void SortTravelCards()
        {
            //arrange
            String[] route = { "Москва", "Кёльн", "Париж", "Лондон", "Мадрид", "Венеция", "Прага", "Варшава", "Осло", "Стокгольм", "Хельсинки" };
            List<TravelCard> initial = GetCardSet(route);
            List<TravelCard> testRoute = GetTestRoute(initial);
            TravelCardsSorter sorter = new TravelCardsSorter();
            //act
            List<TravelCard> result = sorter.Order(testRoute);
            //assert
            Assert.AreEqual(initial, result);
        }

        //составляет набор карточек из набора городов
        public static List<TravelCard> GetCardSet(String[] points)
        {
            List<TravelCard> result = new List<TravelCard>();
            for (Int32 i = 0; i < points.Length - 1; i++)
            {
                result.Add(new TravelCard(points[i], points[i + 1]));
            }
            return result;
        }

        
        //создаёт тестовый набор неупорядоченных карточек
        static public List<TravelCard> GetTestRoute(List<TravelCard> input)
        {
            Random rand = new Random(stRand.Next());
            for (Int32 i = 0; i < input.Count; i++)
            {
                Int32 tarIndex = rand.Next(input.Count);
                TravelCard temp = input[i];
                input.RemoveAt(i);
                input.Insert(tarIndex, temp);
            }
            return input;
        }
    }
}
