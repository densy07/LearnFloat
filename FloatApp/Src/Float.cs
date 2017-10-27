using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatApp
{
    class Float
    {
        [System.Security.SecuritySafeCritical]
        public static unsafe int SingleToInt32Bits (float value)
        {
             return *((int*)&value);
        }

        public static uint GetMantissa (int value)
        {
            int mantissa = value & 0x7FFFFF;
            return (uint)mantissa;
        }

        public static byte GetExponent (int value)
        {
            byte e = (byte)(0xFF & ((value & 0x7F800000) >> 23));
            return e;
        }

        public static float DecodeFloat (int bits)
        {
            uint m = GetMantissa (bits);
            float v1 = m / (float)Math.Pow (2, 23) + 1;

            byte e = GetExponent (bits);
            float v2 = (float)Math.Pow (2, e - 127);

            int v3 = (bits & (1 << 31)) != 0 ? -1 : 1;

            float outValue = v2 * v1 * v3;
            return outValue;
        }
    }
}
