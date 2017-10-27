using System;

namespace LearnFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEncodeAndDecodeFloat();
        }

        static double Test1()
        {
            float f1 = 10;
            int i1 = 20;

            double f2 = Math.PI * f1;
            return i1 * f2;
        }

        public static int SingleToInt32Bits (float value)
        {
            var bytes = BitConverter.GetBytes (value);
            var bits = (int)(bytes[3] << 24 | bytes[2] << 16 | bytes[1] << 8 | bytes[1]);
            return bits;
        }


        static void TestEncodeAndDecodeFloat()
        {
            float value = 1234;
            uint bits = (uint)SingleToInt32Bits(value);
            Console.WriteLine("value to test " + value);

            uint m = GetMantissa(bits);
            float v1 = m / (float)Math.Pow(2, 23) + 1;
            Console.WriteLine($"m: hex = {m:x}, int = {m:d}, value = {v1}");

            byte e = GetExponent(bits);
            float v2 = (float)Math.Pow(2, e - 127);
            Console.WriteLine($"e: hex = {e:x}, int = {e:d}, value = {v2}");

            int v3 = (bits & (1 << 31)) > 0 ? -1 : 1;

            float outValue = v2 * v1 * v3;

            Console.WriteLine("out value is " + outValue);
            Console.ReadKey(true);
        }

        static uint GetMantissa(uint value)
        {
            uint i = value;
            uint mantissa = i & 0x7FFFFF;

            return mantissa;
        }

        static byte GetExponent(uint value)
        {
            var i = value;
            byte e = (byte)(0xFF & ((i & 0x7F800000) >> 23));

            return e;
        }

        static void MaxFloatEqualWithIntegar()
        {
            int i = 0;
            decimal f = 0.0m;

            while (i == f && i >= 0 && f >= 0)
            {
                i += 1;
                f += 1;
            }

            Console.WriteLine();
        }
    }
}
