// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
 
class Program
{
    // entry point
    static void Main()
    {
        AccessClass accessClass = new AccessClass
        {
            // comment-uncomment to test get set
             // our declared values
             //Number1 = 9, // setter value
             //Number2 = 99 // setter value
        };
 
        Console.WriteLine("Output: {0}", accessClass.Number1); // getter
        Console.WriteLine("Output: {0}", accessClass.Number2); // getter
        Console.ReadKey();
    }
}
 
 
public class AccessClass
{
    // our default values
    public int _number1 { get; set; } = 100; // our default value, aka Backing store
    public int _number2 { get; set; } = 200; // our default value, aka Backing store
 
    public int Number1
    {
        get
        {
            return _number1;
        }
        set
        {
            _number1 = value;
        }
    }
 
    public int Number2
    {
        get
        {
            return _number2;
        }
        set
        {
            _number2 = value;
        }
    }
}