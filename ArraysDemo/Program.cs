using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCreate();
            Test1BasedArray();
            MultiDimensionalArrays();

            Console.WriteLine();
            JaggedArraysDemo();

            Console.ReadKey();
        }

        static void ArrayCreate()
        {
            int[] a1;
            a1 = new int[5];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write($"{a3[i]}");
            }
            Console.WriteLine();

            foreach (var i in a4)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();

            //System.Array
            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(1, 0);



           
        }

        static void Test1BasedArray()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.Write($"{myArray.GetValue(i)}" + " ");
            }

            Console.WriteLine();

        }

        static void MultiDimensionalArrays()
        {
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)
                {
                    Console.Write($"{arr1[i, j]}" + " ");
                }

            }
           
        }

        static void JaggedArraysDemo()
        {
            int[][] arr = new int[4][];
            arr[0] = new int[1];
            arr[1] = new int[3];
            arr[2] = new int[2];
            arr[3] = new int[4];

            Console.WriteLine("Enter jagged array elements:");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    arr[i][j] =int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Printing Jagged Array Elements...");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine(" ");
            }
        }

        static void ArraysTimeComplexity(object[] array)
        {
            //access by index O(1)
            Console.WriteLine(array[0]);

            //search for an element O(N)
            int length = array.Length;
            object find = new object();
            for(int i=0;i<length;i++)
            {
                if (array[i] == find)
                    Console.WriteLine("Element Exists/Found");
            }

            //add to a full array
            var bigArray = new int[length * 2];
            Array.Copy(array, bigArray,length);
            bigArray[length + 1] = 10;

            //add to end where there's some space - O(1)
            array[length - 1] = 10;

            //O(1)
            array[6] = null;   //removing an element by assigning null if index is known
        }
    }
}
