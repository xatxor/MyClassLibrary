using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class BubbleSort
    {
        //Алгоритм заключается в циклических проходах по массиву, за каждый проход элементы массива попарно сравниваются и,
        //если их порядок не правильный, то осуществляется обмен.Обход массива повторяется до тех пор, пока массив не будет упорядочен.

        //b - O(n) av - O(n^2) w - O(n^2)

        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static int[] Sort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
