// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.Linq;
 
class Program
{
    static ref int FirstElement(int[] array)
    {        
        return ref array[0];
    }
 
    static void Main()
    {
        int[] array1 = { 1, 4, 2, 7, 6, 4, 4, 5, 3, 7 };
        int[] array2 = new int[10];
        int maxValue = array1.Max();
        int indexElement = Array.IndexOf(array1, maxValue);
 
 
        // display elements in array1
        Console.Write("Original Array1: ");
        for (int i = 0; i < array1.Length; i++)            
        {            
            Console.Write(array1[i]);
            Console.Write(' ');
        }
 
        // max value
        Console.Write("\n\nMax value in array: {0}", maxValue);
        // index of max value
        Console.Write("\n\nIndex of max value in array: {0}", indexElement);
        Console.Write("\n\n");
 
        // sort ascending
        Console.Write("Array1 sorted ascending: ");
        Array.Sort(array1);
        for (int i = 0; i < array1.Length; i++)
        {            
            Console.Write(array1[i]);
            Console.Write(' ');
        }
        Console.Write("\n\n");
 
 
        // sort descending
        Console.Write("Array1 sorted descending: ");
        Array.Reverse(array1);
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i]);
            Console.Write(' ');
        }
        Console.Write("\n\n");
 
        // make a change to array1, index 0
        FirstElement(array1) = 9;
 
        // display elements with a change in array1
        Console.Write("Array1 with changed element: ");
        for (int i = 0; i < array1.Length; i++)            
        {            
            Console.Write(array1[i]);
            Console.Write(' ');
        }
        Console.Write("\n\n");
 
 
        // copy all elements from array1 to array2
        int[] array1OriginalData1 = { 1, 4, 2, 7, 6, 4, 4, 5, 3, 7 };
        Array.Copy(array1OriginalData1, 0, array2, 0, 10);
 
        int[] array1OriginalData2 = { 1, 4, 2, 7, 6, 4, 4, 5, 3, 7 };
         
 
        // display elements in array2
        Console.Write("Array2 copied from Array1: ");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i]);
            Console.Write(' ');
        }
        Console.Write("\n\n");
 
        // Array.Copy
        // p1 = source array
        // p2 = start index in source array
        // p3 = destination array
        // p4 = start index in destination array
        // p5 = elements to copy
 
 
 
        // array1 with index
        Console.Write("Array1 sorted with Index:\n");
        for (int i = 0; i < array1OriginalData1.Length; i++)
        {
            int indexVal = Array.IndexOf(array1OriginalData1, array1OriginalData1[i]);
            Console.Write(array1OriginalData1[i] + "(" + indexVal.ToString() + ")");
            Console.Write(' ');
        }
        Console.Write("\n\n");
 
 
 
        // sort array1 into array2 by max value      
         
        Console.Write("Array2 sorted by max value from Array1: ");
        // sort descending        
        Array.Reverse(array1OriginalData1);
         
        // move by index value to array2
        for (int i = 0; i < array1.Length; i++)
        {
            Array.Copy(array1OriginalData1, i, array2, i, 1);
            Console.Write(array2[i]);
            Console.Write(' ');
        }        
        Console.Write("\n\n");
 
 
        Console.Write("\n\nCleared array 1\n");
        Array.Clear(array1, 0, array1.Length);
        for (int i = 0; i < array1.Length; i++)
        {            
            Console.Write(array1[i]);
            Console.Write(' ');
        }
        Console.Write("\n");
 
        Console.Write("\n\nCleared array 2\n");
        Array.Clear(array2, 0, array2.Length);
        for (int i = 0; i < array2.Length; i++)
        {            
            Console.Write(array2[i]);
            Console.Write(' ');
        }
        Console.Write("\n");
 
        Console.ReadKey();
    }
}