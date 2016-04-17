using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxConsole
{
    public class TravelCardsSorter
    {
        public List<TravelCard> Order(List<TravelCard> input)
        {
            //за одну итерацию внешнего цикла находится элемент, не имеющий предшественников (в подсписке)
            for (Int32 i = 0; i < input.Count - 1; i++)
            {
                String start = input[i].Start;//первый элемент подсписка
                Int32 counter = 0;//считаем сколько карточек было перемещено в начало списка
                //внутренний цикл не закончится. пока не найдется элемент, не имеющий предшественников
                for (Int32 j = i; j < input.Count; j++)
                {
                    if (start == input[j].End)//если находится карточка-предшественник, перемещаем её в начало списка
                    {
                        counter++;
                        start = input[j].Start;
                        TravelCard temp = input[j];
                        input.RemoveAt(j);
                        input.Insert(i, temp);
                        j = i - 1;//для новой карточки ищем предшественника с начала списка
                    }
                }
                //перемещённые в начало списка элементы уже стоят на своих местах
                i += counter;//поэтому игнорируем их
            }
            return input;
        }
        //Сложность данного алгоритма O(n).
    }
}
