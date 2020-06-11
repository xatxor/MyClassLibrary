using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class ShellSort
    {
        // Алгоритм сортировки Шелла базируется на двух идеях:
        //
        // Сортировка вставками показывает лучшие результаты на практически упорядоченных массивах данных;
        // Сортировка вставками неэффективна для смешанных данных, потому что за одну итерацию элементы смещаются только на одну позицию.
        // Для устранения недостатков алгоритма Insertion Sort, в сортировке Шелла осуществляется несколько сортировок вставками.
        // При этом в каждой итерации сравниваются элементы, которые размещены на разных расстояниях один от другого,
        // начиная с наиболее отдаленных (d = 1⁄2 длины массива) до сравнения соседних элементов(d = 1).

        // b - O(n) av - O(n(log(n))^2) w - O((n log)^2 n)

        //метод для обмена элементов
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }

        static int[] Sort(int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }
    }
}
