using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclarationAndInitialized = false;
            isDeclarationAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sbyteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 42;
            int b = 20;

            byte age = 87;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907063d;
            decimal decimalExample = 1.2578907289045789789789789789m;

            Console.WriteLine(1.2578907289045789789789789789f);
            Console.WriteLine(1.2578907289045789789789789789d);
            Console.WriteLine(1.2578907289045789789789789789m);


        }
        enum PastryType { Cake, Cpcake, Croissant, Poptart, Pie, Donut}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Poptart;

        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 112;

            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(1805,12,03);

        }

    }
}
