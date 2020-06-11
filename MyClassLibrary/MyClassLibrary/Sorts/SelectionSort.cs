using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class SelectionSort
    {
        // Алгоритм сортировки выбором состоит из следующих шагов:
        //
        // Для начала определяем позицию минимального элемента массива;
        // Делаем обмен минимального элемента с элементом в начале массива.Получается, что первый элемент массива уже отсортирован;
        // Уменьшаем рабочую область массива, отбрасывая первый элемент, а для подмассива который получился, повторяем сортировку.

        // b - O(n^2) av - O(n^2) w - O(n^2)

        //метод поиска позиции минимального элемента подмассива, начиная с позиции n
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        //метод для обмена элементов
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //сортировка выбором
        static int[] Sort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return Sort(array, currentIndex + 1);
        }
    }
}
