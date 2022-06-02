using System;

namespace DemoTesting
{
    public class Program //definir com a public per poder testejar
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Hello World!");

        }

        public static string MetodeQualsevol()
        {
            return "Algun text";
        }

        public static bool Login(string user, string password) =>
            user == "JAUME" && password == "1234" ? true : false;
    }
}
