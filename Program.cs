using System;

namespace EncryptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            testClass t = new testClass();
            string testUrl = "whateveryouwant?id=25&somethingelse=40";
            Console.WriteLine("Bu normal : " + (testUrl));
            string sifreli = t.Encrypt(testUrl);
            Console.WriteLine("Bu encrypt : " + sifreli);
            Console.WriteLine("Bu decrypt : " + t.Decrypt(sifreli));

            Console.ReadKey();
        }
    }
}
