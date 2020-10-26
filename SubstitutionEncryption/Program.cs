using System;

namespace SubstitutionEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Chiper chiffer = new Chiper(1);

            string plainText = "abcdefghijklmnopqrstuvwxyz";
            string encryptedString = chiffer.Encrypt(plainText);
            string decryptedString = chiffer.Decrypt(encryptedString);

            Console.WriteLine($"Orginal   text: {plainText}");
            Console.WriteLine($"Encrypted text: {encryptedString}");
            Console.WriteLine($"Decrypted text: {decryptedString}");

        }
    }
}
