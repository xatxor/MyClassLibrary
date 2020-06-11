using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class QuickSort
    {
        // Идея алгоритма следующая:
        //
        // Необходимо выбрать опорный элемент массива, им может быть любой элемент, от этого не зависит правильность работы алгоритма;
        // Разделить массив на три части, в первую должны войти элементы меньше опорного, во вторую - равные опорному и в третью - все элементы больше опорного;
        // Рекурсивно выполняются предыдущие шаги, для подмассивов с меньшими и большими значениями, до тех пор, пока в них содержится больше одного элемента.

        // b - O(n log(n)) av - O(n log(n)) w - O(n^2)

        // метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        //быстрая сортировка
        static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }
    }
}
