using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class InsertionSort
    {
        // Алгоритм работы сортировки вставками заключается в следующем:
        //
        // в начале работы упорядоченная часть пуста;
        // добавляем в отсортированную область первый элемент массива из неупорядоченных данных;
        // переходим к следующему элементу в не отсортированных данных, и находим ему правильную позицию в отсортированной части массива, тем самым мы расширяем область упорядоченных данных;
        // повторяем предыдущий шаг для всех оставшихся элементов.

        // b - O(n) av - O(n^2) w - O(n^2)

        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка вставками
        static int[] Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }
    }
}
