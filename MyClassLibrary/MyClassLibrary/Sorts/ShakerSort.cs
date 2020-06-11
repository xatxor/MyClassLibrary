using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class ShakerSort
    {
        // Проанализировав алгоритм пузырьковой сортировки, можно заметить:
        //
        // если при обходе части массива не было обменов элементов, то эту часть можно исключить, так как она уже отсортирована;
        // при проходе от конца массива к началу минимальное значение сдвигается на первую позицию, при этом максимальный элемент перемещается только на один индекс вправо.
        //
        // Исходя из приведенных идей, модифицируем сортировку пузырьком следующим образом:
        //
        // на каждой итерации, фиксируем границы части массива в которой происходит обмен;
        // массив обходиться поочередно от начала массива к концу и от конца к началу;
        //
        // При этом минимальный элемент перемещается в начало массива, а максимальный - в конец, после этого уменьшается рабочая область массива.

        // b - O(n) av - O(n^2) w - O(n^2)
        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка перемешиванием
        static int[] Sort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }
    }
}
