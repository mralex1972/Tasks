// 1. Написать функцию вывода одномерного целочисленного массива.
// void PrintArray( int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] massiv = {1,2,3,4,5,6,7,8,9};
// PrintArray(massiv);
// 
// 2.  Задать целочисленный массив, состоящий из элементов 0 и 1. 
// Например: [ 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 ]. 
// С помощью цикла и условия заменить 0 на 1, 1 на 0.
// int[] array = {1, 1, 0, 0, 1, 0, 1, 1, 0, 0};
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == 0) array[i] = 1;
//     else array[i] = 0;
//     Console.Write(array[i] + " ");
// }
// 
// 3. Задать пустой целочисленный массив длиной 100. 
// С помощью цикла заполнить его значениями 1 2 3 4 5 6 7 8 … 100
// int[] array = new int[100];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i + 1;
//     Console.Write(array[i] + " ");
// }
// 
// 4.  Задать массив [ 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 ] 
// пройти по нему циклом, и числа меньшие 6 умножить на 2.
// int[] array = {1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1};
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 6) array[i] = array[i] * 2;
//     Console.Write(array[i] + " ");
// }
// 
// 5.  Написать метод, принимающий на вход два аргумента: len и initialValue,
//  и возвращающий одномерный массив типа int длиной len, каждая ячейка которого равна initialValue
// int[] Repeat( int len, int initialValue)
// {
//     int[] array = new int[len];
//     for (int i = 0; i< len; i++)
//     {
//     array[i] = initialValue;
//     }
//     return array;
// }
// int[] array = Repeat(10, 456);
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// 
// 6. Задать одномерный массив и найти в нем минимальный и максимальный элементы.
// int[] array={21,13,14,600,47,39,58,7,92};
// int min = array[0];
// int max = array[0];
// for(int i = 1; i< array.Length; i++)
// {
// if (min > array[i]) min = array[i];
// if (max < array[i]) max = array[i];
// }
// Console.WriteLine("Минимальный элемент = " + min);
// Console.WriteLine("Максимальный элемент = " + max);
// 
// 7. Написать метод, в который передается не пустой одномерный целочисленный массив, метод должен вернуть true, 
// если в массиве есть место, в котором сумма левой и правой части массива равны.
// int SumArr(int[] arr)
// {
//     int s = 0;
//     for (int i=0; i<arr.Length; i++)
//     {
//         s = s + arr[i];
//     }
//     return s;
// }
// void balance(int[] Array)
// {
//     if (SumArr(Array) % 2 > 0) 
//     {
//     Console.WriteLine("Fals");
//     return;
//     }
//     int[] leftArr = new int[Array.Length];
//     int j = 0;
//     leftArr[0] = Array[0];
//     while (SumArr(leftArr) <= SumArr(Array)/2)
//     {        
//         if (SumArr(leftArr) == SumArr(Array)/2)
//         {
//             Console.WriteLine("True");
//             for (int k=0; k<j+1; k++)
//             {
//                 Console.Write(Array[k] + " ");
//             }
//             Console.Write("||| ");
//             for (int k=j+1; k < Array.Length; k++)
//             {
//                 Console.Write(Array[k] + " ");
//             }
//             return;
//         }
//         else 
//         {
//             j++;
//             leftArr[j] = Array[j];
//         }
        
//     }
//     Console.WriteLine("Fals");
//     return;
// }
//     int[] massiv = {2, 2, 1, 2, 2, 2, 10, 1};
//     balance(massiv);