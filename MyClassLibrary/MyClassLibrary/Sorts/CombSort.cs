using System;
using System.Collections.Generic;
using System.Text;

namespace SortsAndSearchАlgorithms.Sorts
{
    static class CombSort
    {
        // В сортировке пузырьком всегда сравниваются два соседних элемента, расстояние между ними равно единице, массива данных.
        // Основная идея сортировки расческой в использовании большего расстояния между сравниваемыми элементами.
        // При этом первоначально необходимо брать большое расстояние, и постепенно уменьшать его, по мере упорядочивания данных вплоть до единицы.
        // Изначально сравнивается первый и последний элемент массива, и на каждой итерации уменьшается разрыв между элементами на фактор уменьшения.
        // Итерации продолжаются до тех пор, пока разность индексов больше единицы, а замет массив сортируется пузырьковой сортировкой.
        //
        //
        // Оптимальное значение фактора уменьшения равно 1/(1-e-φ) ≈ 1.247, где е – основание натурального логарифма, а φ – золотое сечение.

        // b - O(n log(n)) av - O(n^2/2^p) (p is a number of increment) w - O(n^2)

        //метод обмена элементов
        static void Swap(ref int value1, ref int value2)
        {
            var temp = value1;
            value1 = value2;
            value2 = temp;
        }

        //метод для генерации следующего шага
        static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s > 1 ? s : 1;
        }

        static int[] Sort(int[] array)
        {
            var arrayLength = array.Length;
            var currentStep = arrayLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i] > array[i + currentStep])
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            //сортировка пузырьком
            for (var i = 1; i < arrayLength; i++)
            {
                var swapFlag = false;
                for (var j = 0; j < arrayLength - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }

        //метод для получения массива заполненного случайными числами
        static int[] GetRandomArray(int length, int minValue, int maxValue)
        {
            var r = new Random();
            var outputArray = new int[length];
            for (var i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = r.Next(minValue, maxValue);
            }

            return outputArray;
        }
    }
}
