// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.ComponentModel.DataAnnotations;
 
class CheckEmails
{
    static void Main(string[] args)
    {
        var objEmail = new EmailAddressAttribute();
        bool testEmailAddress;
        testEmailAddress = objEmail.IsValid("eddie@aol.com");         
        Console.Write("eddie@aol.com: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("eddie@aol.org");       
        Console.Write("\n\neddie@aol.org: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("eddie+isme@aol.net");     
        Console.Write("\n\neddie+isme@aol.net: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("edward@aol.yooo");      
        Console.Write("\n\nedward@aol.yooo: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("test");                         
        Console.Write("\n\ntest: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("test@");                         
        Console.Write("\n\ntest@: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("test@abcd");                     
        Console.Write("\n\ntest@abcd: " + testEmailAddress);
 
        testEmailAddress = objEmail.IsValid("test@abcd.");                    
        Console.Write("\n\ntest@abcd.: " + testEmailAddress);
 
        // using an if statement
        if (new EmailAddressAttribute().IsValid("\n\neddie@aol.com"))
            testEmailAddress = true;
            Console.Write("\n\neddie@aol.com: " + testEmailAddress);
 
        // wait
        Console.ReadKey();
    }
}