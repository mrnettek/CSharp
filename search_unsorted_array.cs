// MrNetTek
// eddiejackson.net/blog
// 1/5/2020
// free for public use 
// free to claim as your own
 
using System;
 
namespace SearchUnsortedArray
{
    class Program
    {
        static void Main()
        {
             
            // the array with values
            int[] array1 = { 4, 6, 1, 5, 8, 7, 3, 2, 6, 2, 7, 4, 0, 5};
             
            // dynamic length of array
            int a = array1.Length;
 
            // value to search for
            int b = 9;
 
            // search array
            bool retBool = UnsortedInput(array1, a, b);
 
            // does value exist in array?
            Console.WriteLine(retBool);
            Console.ReadKey();
 
            // clear session
            Array.Clear(array1, 0, array1.Length);
             
        }
 
        static public bool UnsortedInput(int[] arrInput, int arrSize, int searchValue)
        {
 
            for (int i = 0; i < arrSize; i++)
            {
                if (searchValue == arrInput[i])
                {
                    return true;
                }
                                 
            }
 
            return false;
        }
 
    }
}
