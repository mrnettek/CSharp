// MrNetTek
// eddiejackson.net/blog
// 12/20/2019
// free for public use 
// free to claim as your own
 
using System;
 
public class CopyArray
{
    public static void Main()
    {
        int[] array1 = {10,5,20,15,30,15,1,2,3,4};
        int[] array2 = new int[10];
        int i;
 
        // load elements into array 1
        for (i = 0; i < array1.Length; i++)
        {
            Console.Write("{0} ", array1[i]);            
        }
 
 
        // load elements from array 1 into array 2
        Console.WriteLine("\n");
        for (i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i];
            Console.Write("{0} ", array2[i]);
        }
 
 
        // reverse items in array1
        Console.WriteLine("\n");
         
        Array.Reverse(array1);
        for (i = 0; i < array1.Length; i++)
        {
            Console.Write("{0} ", array1[i]);
        }
 
         
        // load reversed elements from array 1 into array 2
        Console.WriteLine("\n");
        for (i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i];
            Console.Write("{0} ", array2[i]);
        }
 
 
        Console.ReadKey();
    }
}
