using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class MergeSort
    {
        // Алгоритм сортировки слиянием выглядит следующим образом:
        //
        // Входной массив разбивается на две части одинакового размера;
        // Каждый из подмассивов сортируется отдельно, по этому же принципу, тоесть производится повторное разбитие до тех пор,
        // пока длина подмассива не достигнет единицы.В таком случае каждый единичный массив считается отсортированным;
        // После этого осуществляется слияние всех подмассивов в один, в результате чего получаем отсортированные данные

        // b - O(n log(n)) av - O(n log(n)) w - O(n log(n))

        //метод для слияния массивов
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
        static int[] Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Sort(array, lowIndex, middleIndex);
                Sort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }
    }
}
