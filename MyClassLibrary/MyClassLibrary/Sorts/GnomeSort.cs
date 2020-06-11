using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class GnomeSort
    {
        // Алгоритм находит первую пару неотсортированных элементов массива и меняет их местами.
        // При этом учитывается факт, что обмент приводит к неправильному расположению элементов примыкающих с обеих сторон  к только что переставленным.
        // Поскольку все элементы массива после переставленных не отсортированны, необходимо перепроверить только элементы до переставленных.

        // b - O(n) av - O(n^2) w - O(n^2)

        //метод для обмена элементов
        static void Swap(ref int item1, ref int item2)
        {
            var temp = item1;
            item1 = item2;
            item2 = temp;
        }

        //Гномья сортировка
        static int[] Sort(int[] unsortedArray)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Length)
            {
                if (unsortedArray[index - 1] < unsortedArray[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return unsortedArray;
        }
    }
}
