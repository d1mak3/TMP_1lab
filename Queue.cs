using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TMP_1lab
{
    class Queue
    {
        private int[] queue = new int[0];

        public Queue(int[] _oldQueue, int _index)//Копирует очередь до определённого числа
        {
            for (int i = 0; i < _index; ++i)
            {
                queue[i] = _oldQueue[i];
            }
        }

        public Queue(int[] _oldQueue, int _index1, int _index2)//Копирует очердь с определённого числа до определённого числа
        {
            for (int i = _index1; i < _index2; ++i)
            {
                queue[i] = _oldQueue[i];
            }
        }

        public Queue(int[] _copyQueue)
        {
            queue = _copyQueue;
        }

        public int QueueSize //Размер очереди
        {
            get
            {
                int size = 0;

                foreach (int o in queue)
                {
                    ++size;
                }
                return size;
            }
        }

        public void Push(int _newElement)//Добавляет число _newElement в конец очереди (в начало массива)
        {
            int[] temp = new int[QueueSize];
            for (int i = QueueSize; i >= 0; i--)
            {
                queue[i] = queue[i - 1];
            }
            queue[0] = _newElement;
        }

        public int Pop()//Возвращает первый элемент в очереди (последний элемент массива) и при этом удаляет его из этой очереди
        {
            int rez = queue[QueueSize];
            for (int i = 0; i < QueueSize; ++i)
            {

            }
            return rez;
        }

        public int Back()//Возвращает первый элемент в очереди (последний в массиве) и НЕ удаляет его из очереди
        {
            int rez = queue[QueueSize];
            return rez;
        }

        public void Sort(int k, int[] queue)
        {
            var count = new int[k + 1]; ;
            for (int i = 0; i < QueueSize; i++)
            {
                count[queue[i]++];
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    queue[index] = i;
                    index++;
                }
            }
        }
        public void Print()
        {
            foreach (int item in queue)
                Console.WriteLine(item);
            Console.WriteLine("---------");
        }
    }
}

