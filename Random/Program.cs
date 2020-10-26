using System;
using System.Security.Cryptography;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Benchmark benchmark = new Benchmark("random numbers"))
            {
                int[] randomNumbers = GetRandomNumbers(100000000);
            }


            using (Benchmark benchmark = new Benchmark("crypto random numbers"))
            {
                int[] cryptoRandomNumbers = GetCryptoRandomNumbers(100000000);
            }
        }

        public static int[] GetRandomNumbers(int iterations)
        {
            System.Random random = new System.Random();
            int[] numbers = new int[iterations];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next();
                }
            }

            return numbers;
        }

        public static int[] GetCryptoRandomNumbers(int iterations)
        {
            int[] numbers = new int[iterations];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    byte[] data = new byte[4];
                    rNGCrypto.GetBytes(data);

                    numbers[i] = BitConverter.ToInt32(data, 0);
                }
            }

            return numbers;
        }
    }
}
