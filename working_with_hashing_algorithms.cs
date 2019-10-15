// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.Text;
using System.Security.Cryptography;
 
public class ReturnHash
{
    public static string ComputeHash(string plainText, string hashAlgorithm, byte[] saltBytes)
    {
        // Salt size
        saltBytes = new byte[8];
 
        // Convert Text to Array
        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
 
        // Create Array
        byte[] plainTextSaltBytes =
                new byte[plainTextBytes.Length + saltBytes.Length];
 
        // Copy Text into Array
        for (int i = 0; i < plainTextBytes.Length; i++)
            plainTextSaltBytes[i] = plainTextBytes[i];
 
        // Append Salt
        for (int i = 0; i < saltBytes.Length; i++)
            plainTextSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
 
        // Algorithm
        HashAlgorithm hash;
 
        // Initialize Class
        switch (hashAlgorithm.ToUpper())
        {
            case "SHA1":
                hash = new SHA1Managed();
                break;
 
            case "SHA256":
                hash = new SHA256Managed();
                break;
 
            case "SHA384":
                hash = new SHA384Managed();
                break;
 
            case "SHA512":
                hash = new SHA512Managed();
                break;
 
            default:
                hash = new MD5CryptoServiceProvider();
                break;
        }
 
        byte[] hashBytes = hash.ComputeHash(plainTextSaltBytes);
 
        byte[] hashSaltBytes = new byte[hashBytes.Length +
                                            saltBytes.Length];
 
        // Hash to Array
        for (int i = 0; i < hashBytes.Length; i++)
            hashSaltBytes[i] = hashBytes[i];
 
        // Append Salt
        for (int i = 0; i < saltBytes.Length; i++)
            hashSaltBytes[hashBytes.Length + i] = saltBytes[i];
 
        // Convert result into a base64-encoded string.
        string hashValue = Convert.ToBase64String(hashSaltBytes);
 
        // Return Result
        return hashValue;
    }
 
    public static bool VerifyHash(string plainText,
                                  string hashAlgorithm,
                                  string hashValue)
    {
        // Base64-encoded hash
        byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);
 
        // Hash without Salt
        int hashSizeInBits, hashSizeInBytes;
 
        // Size of hash is based on the specified algorithm.
        switch (hashAlgorithm.ToUpper())
        {
            case "SHA1":
                hashSizeInBits = 160;
                break;
 
            case "SHA256":
                hashSizeInBits = 256;
                break;
 
            case "SHA384":
                hashSizeInBits = 384;
                break;
 
            case "SHA512":
                hashSizeInBits = 512;
                break;
 
            default: // MD5
                hashSizeInBits = 128;
                break;
        }
 
        // Convert to bytes.
        hashSizeInBytes = hashSizeInBits / 8;
 
        // Verify Hash Length
        if (hashWithSaltBytes.Length < hashSizeInBytes)
            return false;
 
        // Array to hold Salt
        byte[] saltBytes = new byte[hashWithSaltBytes.Length -
                                    hashSizeInBytes];
 
        // Salt to New Array
        for (int i = 0; i < saltBytes.Length; i++)
            saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
 
        string expectedHashString =
                    ComputeHash(plainText, hashAlgorithm, saltBytes);
 
        return (hashValue == expectedHashString);
    }
}
 
public class PasswordEncodingTest1
{
    [STAThread]
    static void Main(string[] args)
    {
        // Test Passwords
        string rightPassword = "TRUEPassword$";
        string wrongPassword = "FALSEPassword$";
 
        string passwordHashMD5 =
               ReturnHash.ComputeHash(rightPassword, "MD5", null);
        string passwordHashSha1 =
               ReturnHash.ComputeHash(rightPassword, "SHA1", null);
        string passwordHashSha256 =
               ReturnHash.ComputeHash(rightPassword, "SHA256", null);
        string passwordHashSha384 =
               ReturnHash.ComputeHash(rightPassword, "SHA384", null);
        string passwordHashSha512 =
               ReturnHash.ComputeHash(rightPassword, "SHA512", null);
 
         
        Console.WriteLine("Hash and Comparison--- \r\n");
 
        // md5
        Console.WriteLine("MD5 {0}", passwordHashMD5);
            Console.WriteLine("Right PW MD5     {0}",
            ReturnHash.VerifyHash(
            rightPassword, "MD5",
            passwordHashMD5).ToString());
            Console.WriteLine("Wrong PW MD5     {0}",
            ReturnHash.VerifyHash(
            wrongPassword, "MD5",
            passwordHashMD5).ToString());
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/MD5
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx
 
        // sha1
        Console.WriteLine("SHA1 {0}", passwordHashSha1);
            Console.WriteLine("Right PW SHA1    {0}",
            ReturnHash.VerifyHash(
            rightPassword, "SHA1",
            passwordHashSha1).ToString());
            Console.WriteLine("Wrong PW SHA1    {0}",
            ReturnHash.VerifyHash(
            wrongPassword, "SHA1",
            passwordHashSha1).ToString());
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/SHA-1
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha1(v=vs.110).aspx
 
        // sha256
        Console.WriteLine("SHA256 {0}", passwordHashSha256);
            Console.WriteLine("Right PW SHA256  {0}",
            ReturnHash.VerifyHash(
            rightPassword, "SHA256",
            passwordHashSha256).ToString());
            Console.WriteLine("Wrong PW SHA256  {0}",
            ReturnHash.VerifyHash(
            wrongPassword, "SHA256",
            passwordHashSha256).ToString());
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/SHA-2
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha256(v=vs.110).aspx
 
        // sha384
        Console.WriteLine("SHA384 {0}", passwordHashSha384);
            Console.WriteLine("Right PW SHA384  {0}",
            ReturnHash.VerifyHash(
            rightPassword, "SHA384",
            passwordHashSha384).ToString());
            Console.WriteLine("Wrong PW SHA384  {0}",
            ReturnHash.VerifyHash(
            wrongPassword, "SHA384",
            passwordHashSha384).ToString());
            Console.WriteLine("");
            // reference https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha384(v=vs.110).aspx
 
        // sha512
        Console.WriteLine("SHA512 {0}", passwordHashSha512);
            Console.WriteLine("Right PW SHA512  {0}",
            ReturnHash.VerifyHash(
            rightPassword, "SHA512",
            passwordHashSha512).ToString());
            Console.WriteLine("Wrong PW SHA512  {0}",
            ReturnHash.VerifyHash(
            wrongPassword, "SHA512",
            passwordHashSha512).ToString());
            // reference https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha512(v=vs.110).aspx
 
        Console.WriteLine("");
        Console.WriteLine("");
 
 
        Console.ReadKey();
    }
}