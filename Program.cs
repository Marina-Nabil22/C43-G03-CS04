using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1=new int[4];
            //int[] arr2 = new int[4];
            //int[] arr3 =new int[arr1.Length+arr2.Length];
            //bool flag1;
            //bool flag2;

            //for(int i=0; i<arr1.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter the value {i+1} of the 1st array: ");
            //        flag1 = int.TryParse(Console.ReadLine(), out arr1[i]);
            //    }while(!flag1);

            //}


            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter the values {i+1} of the 2nd array: ");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    }while(!flag2);
            //}
            //Console.WriteLine();
            //int[] SortFun(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        for (int j = 0; j < arr.Length - i - 1; j++)
            //        {
            //            if (arr[j] > arr[j + 1])
            //            {
            //                // Swap array[j] and array[j + 1]
            //                int temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //            }
            //        }
            //    }

            //    return arr;
            //}

            //for(int i=0;i<arr1.Length;i++) {
            //    arr3[i] = arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr3[i+ arr1.Length] = arr2[i];
            //}
            //arr3=SortFun(arr3);
            //Console.Clear();
            //Console.WriteLine("The Sorted array: ");
            //foreach (int i in arr3) { 
            //Console.WriteLine(i);
            //}

            #endregion
            #region 2- Write a program in C# Sharp to count the frequency of each element of an array.
            //int [] arr = new int[10];
            //int[] visited=new int[10];
            //bool flag;
            //for(int i=0; i<arr.Length; )
            //{
            //    Console.WriteLine($"Enter Value {i+ 1}");
            //    flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag)
            //    {
            //        visited[i] = 0;
            //        i++;
            //    }
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (visited[i] ==1 )
            //        continue;

            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j] && visited[j]==0)
            //        {
            //            visited[j] =1;

            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"the value {arr[i]} is repeated {count}");
            //}

            #endregion
            #region 3- Write a program in C# Sharp to find maximum and minimum element in an array

            //bool flag, flag2;
            //int n;
            //do {
            //    Console.WriteLine("Enter the array size:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //}while(!flag);
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.WriteLine($"Enter Value {i + 1}");
            //    flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag2)
            //    {
            //        i++;
            //    }
            //}
            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] <= min)
            //        min = arr[i];
            //    else if (arr[i] >= max)
            //        max = arr[i];

            //}
            //Console.WriteLine($"Tha Max value is {max} and the Min value is {min}");

            #endregion
            #region 4- Write a program in C# Sharp to find the second largest element in an array.
            //bool flag, flag2;
            //int n;
            //do {
            //    Console.WriteLine("Enter the array size:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //}while(!flag);
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.WriteLine($"Enter Value {i + 1}");
            //    flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag2)
            //    {
            //        i++;
            //    }
            //}
            //int max = int.MinValue;
            //int secondMax = int.MinValue;    
            //for (int i = 0; i < arr.Length;i++)
            //{
            //    if (arr[i]>max)
            //    {
            //        secondMax = max;
            //        max= arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != max)
            //    {
            //        secondMax = arr[i];
            //    }

            //}
            //Console.WriteLine("Second Largest Element: " + secondMax);

            #endregion

            #region 5- Consider an Array of Integer values with size N, having values as in this Example
            //bool flag, flag2;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the array size:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.WriteLine($"Enter Value {i + 1}");
            //    flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag2)
            //    {
            //        i++;
            //    }
            //}

            //int MaxDistance = -1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dis = j - i - 1;
            //            if (dis > MaxDistance)
            //                MaxDistance = dis;


            //        }
            //    }
            //}
            //if(MaxDistance==-1)
            //    MaxDistance= 0;

            //Console.WriteLine("Longest Distance = " + MaxDistance);

            #endregion

            #region 6- Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter a Text: ");
            //string? input = Console.ReadLine();

            //if (input != null)
            //{
            //    string reversed = string.Join(" ", input.Split(' ').Reverse());
            //    Console.WriteLine(reversed);
            //}


            #endregion

            #region 7-Write a program to create two multidimensional arrays of same size
            //bool flag, flag2;
            //int n1,n2;
            //do
            //{
            //    Console.WriteLine("Enter the number of rows :");
            //    flag = int.TryParse(Console.ReadLine(), out n1);
            //} while (!flag);

            //do
            //{
            //    Console.WriteLine("Enter the number of columns :");
            //    flag = int.TryParse(Console.ReadLine(), out n2);
            //} while (!flag);


            //int[,] arr1 = new int[n1, n2];
            //int[,] arr2 = new int[n1, n2];

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the values of row{i + 1} :");
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"Enter the value {j + 1}: ");
            //            flag2 = int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //        } while (!flag2);
            //    }
            //}

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Values of row {i + 1}");
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr2[i, j]} ");


            //    }
            //    Console.WriteLine("");
            //}


            #endregion

            #region 8 - Write a Program to Print One Dimensional Array in Reverse Order
            //bool flag, flag2;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the array size:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.WriteLine($"Enter Value {i + 1}");
            //    flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag2)
            //    {
            //        i++;
            //    }
            //}
            //for(int i= arr.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region 9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            //passing by value[Value type] >>  This means that any changes made to the parameter inside the method do not affect the original variable outside the method
            static void Swap1( int X,  int y)
            {
                int temp = X;
                X = y;
                y = temp;
                Console.WriteLine($"X= {X} , Y={y}");


            }


            // passing by reference[Value type] >>This means that any changes made to the parameter inside the method will affect the original variable.
            static void Swap2(ref int X, ref int y)
            {
                int temp = X;
                X = y;
                y = temp;
                Console.WriteLine($"X= {X} , Y={y}");


            }

            #endregion


            #region 10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //passing by value [Reference type] >> Changes to the parameter affect the original variable,A reference to the original variable is passed,2 references to one object.
            static int SumArray(int[] Arr)
            {
                int sum = 0;
                if (Arr is not null)
                {
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr = new int[3];
                        Arr[i] = +2;
                        sum += Arr[i];
                    }
                }
                return sum;
            }



            //passing by reference [Reference type] >> one reference to one object ,Changes to the parameter affect the original variable.
            static int SumArray2(ref int[] Arr)
            {
                int sum = 0;
                if (Arr is not null)
                {
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr = new int[3];
                        Arr[i] = +2;
                        sum += Arr[i];
                    }
                }
                return sum;
            }
            #endregion


            #region 11-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void CalSumAndSub(int a, int b, out int sum, out int sub)
            //{
            //    sum = a + b;
            //    sub = a - b;
            //}
            //int sum, sub;
            //CalSumAndSub(2, 3, out sum, out sub);
            //Console.WriteLine($"Sum of 2 + 3 = {sum} \nSub of 2 - 3= {sub}");


            #endregion

            #region 12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //bool flag;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter a Number:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int num = n;
            //int sum = 0;
            //while (n>0)
            //{

            //    int y = n % 10;
            //    sum+= y;    
            //    n /= 10;


            //}

            //Console.WriteLine($"The sum of the digits of the number {num} is: {sum}");

            #endregion


            #region 13-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int num)
            //{

            //    if (num == 1)
            //    {
            //        return false;
            //    }
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //            return false;

            //    }
            //    return true;

            //}
            //bool flag;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter a Number:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);

            //Console.WriteLine($"is number {n} a prime ? {IsPrime(n)}");
            //Console.ReadLine();

            #endregion


            #region 14-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(int[] arr, out int max, out int min)
            //{
            //    max = arr[0];
            //    min = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (max < arr[i])
            //        {
            //            max = arr[i];
            //        }
            //        if (min > arr[i])
            //        {
            //            min = arr[i];
            //        }
            //    }

            //}

            //bool flag, flag2;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the array size:");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.WriteLine($"Enter Value {i + 1}");
            //    flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (flag2)
            //    {
            //        i++;
            //    }
            //}

            //int max, min;
            //MinMaxArray(arr, out max, out min);
            //Console.WriteLine($"Max = {max} \nMin={min}");


            #endregion


            #region 15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //static int Fact(int n)
            //{
            //    int res = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        res *= i;
            //    }
            //    return res;
            //}


            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter a Number:");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //Console.WriteLine($"The factorial of {num} = {Fact(num)}");

            #endregion


            #region 16-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //static string ChangeChar(int position ,string text,char a)
            //{
            //    text=text.Remove(position,1);
            //    text = text.Insert(position, a.ToString());
            //    return text;
            //}
            //string text = "session 4";
            //text = ChangeChar(2, text, 'm');
            //Console.WriteLine(text);
            //Console.ReadLine();
            #endregion


        }
    }
}