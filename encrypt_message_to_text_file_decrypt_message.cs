// MrNetTek
// eddiejackson.net/blog
// 11/30/2020
// free for public use
// free to claim as your own
 
using System;
using System.IO;
using System.Security.Cryptography;
 
public class EncryptDecrypt
{
    public static void Main(string[] args)
    {
        // encryption key for encryption/decryption 
        byte[] key = { 0x02, 0x03, 0x01, 0x03, 0x03, 0x07, 0x07, 0x08, 0x09, 0x09, 0x11, 0x11, 0x16, 0x17, 0x19, 0x16 };
 
        // ENCRYPT DATA
        try
        {
            // create file stream
            using FileStream myStream = new FileStream(@"C:\csharp\encrypted.txt", FileMode.OpenOrCreate);
 
            // configure encryption key.  
            using Aes aes = Aes.Create();
            aes.Key = key;
 
            // store IV
            byte[] iv = aes.IV;
            myStream.Write(iv, 0, iv.Length);
 
            // encrypt filestream  
            using CryptoStream cryptStream = new CryptoStream(
                myStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write);
 
            // write to filestream
            using StreamWriter sWriter = new StreamWriter(cryptStream);
            string plainText = "Welcome to the lab of MrNetTek!";
            sWriter.WriteLine(plainText);
 
            // done 
            Console.WriteLine("---SUCCESSFUL ENCRYPTION---\n");
 
        }
        catch
        {
            // error  
            Console.WriteLine("---ENCRYPTION FAILED---");
            throw;
        }
 
        // SHOW ENCRYPTED DATA
        try
        {
            string text = System.IO.File.ReadAllText(@"C:\csharp\encrypted.txt");
 
            // encrypted data
            Console.WriteLine("Encrypted Data: {0}\n\n", text);
 
            Console.WriteLine("Press any key to view decrypted data\n");
            Console.ReadKey();
        }
        catch
        {
            throw;
        }
 
        // DECRYPT DATA
        try
        {
            // create file stream
            using FileStream myStream = new FileStream(@"c:\csharp\encrypted.txt", FileMode.Open);
             
            // create instance
            using Aes aes = Aes.Create();
 
            // reads IV value
            byte[] iv = new byte[aes.IV.Length];
            myStream.Read(iv, 0, iv.Length);
 
            // decrypt data
            using CryptoStream cryptStream = new CryptoStream(
               myStream,
               aes.CreateDecryptor(key, iv),
               CryptoStreamMode.Read);
 
            // read stream
            using StreamReader sReader = new StreamReader(cryptStream);
 
            // display stream
            Console.WriteLine("\n---SUCCESSFUL DECRYPTION---\n");
            Console.WriteLine("Decrypted data: {0}", sReader.ReadToEnd());
            Console.ReadKey();
        }
        catch
        {
            // error
            Console.WriteLine("---DECRYPTION FAILED---");
            throw;
        }
    }
}